
using System;
using System.Collections.Generic;

public class EventBus
{
    private static EventBus sInstance;
    private readonly static Dictionary<Type, List<Type>> sEventTypesCache = new Dictionary<Type, List<Type>>();
    private readonly Dictionary<Type, List<Subscription>> subscriptionsByEventType = new Dictionary<Type, List<Subscription>>();
    private readonly Dictionary<Object, List<Type>> typesBySubscriber = new Dictionary<object, List<Type>>();
    private readonly SubcriberMethodFinder subcriberMethodFinder = new SubcriberMethodFinder();

    private readonly PostingThreadState currentPostingThreadState = new PostingThreadState();

    private EventBus()
    {

    }

    public static EventBus GetDefault()
    {
        if (sInstance == null)
        {
            sInstance = new EventBus();
        }
        return sInstance;
    }

    public void Register(object subscriber)
    {
        List<SubscriberMethod> subscriberMethods = subcriberMethodFinder.FindSubscriberMethods(subscriber.GetType());
        foreach (SubscriberMethod subscriberMethod in subscriberMethods)
        {
            Subscribe(subscriber, subscriberMethod);
        }
    }

    private void Subscribe(object subscriber, SubscriberMethod subscriberMethod)
    {
        Type eventType = subscriberMethod.eventType;
        Subscription newSubscription = new Subscription(subscriber, subscriberMethod);
        List<Subscription> subscriptions;
        subscriptionsByEventType.TryGetValue(eventType, out subscriptions);
        if (subscriptions == null)
        {
            subscriptions = new List<Subscription>();
            subscriptionsByEventType.Add(eventType, subscriptions);
        }
        else
        {
            if (subscriptions.Contains(newSubscription))
            {
                throw new EventException("Subscriber " + subscriber.GetType() + " already registered to event "
                        + eventType);
            }
        }
        subscriptions.Add(newSubscription);
        subscriptions.Sort(delegate (Subscription left, Subscription right)
        {
            return left.subscriberMethod.priority >= right.subscriberMethod.priority ? 1 : -1;
        });

        List<Type> subscribedEvents;
        typesBySubscriber.TryGetValue(subscriber, out subscribedEvents);
        if (subscribedEvents == null)
        {
            subscribedEvents = new List<Type>();
            typesBySubscriber.Add(subscriber, subscribedEvents);
        }
        subscribedEvents.Add(eventType);
    }

    /** Only updates subscriptionsByEventType, not typesBySubscriber! Caller must update typesBySubscriber. */
    private void UnsubscribeByEventType(Object subscriber, Type eventType)
    {
        List<Subscription> subscriptions;
        subscriptionsByEventType.TryGetValue(eventType, out subscriptions);
        if (subscriptions != null)
        {
            foreach (Subscription subscription in subscriptions)
            {
                if (subscription.subscriber == subscriber)
                {
                    subscription.active = false;
                    subscriptions.Remove(subscription);
                }
            }
        }
    }

    public void Unregister(object subscriber)
    {
        List<Type> subscribedTypes;
        typesBySubscriber.TryGetValue(subscriber, out subscribedTypes);
        if (subscribedTypes != null)
        {
            foreach (Type eventType in subscribedTypes)
            {
                UnsubscribeByEventType(subscriber, eventType);
            }
            typesBySubscriber.Remove(subscriber);
        }
    }

    public void Post(object notification)
    {
        currentPostingThreadState.eventQueue.Add(notification);
        if (!currentPostingThreadState.isPosting)
        {
            currentPostingThreadState.isPosting = true;
            try
            {
                while (currentPostingThreadState.eventQueue.Count > 0)
                {
                    object nextNotification = currentPostingThreadState.eventQueue[0];
                    currentPostingThreadState.eventQueue.Remove(nextNotification);
                    PostSingleEvent(nextNotification, currentPostingThreadState);
                };
            }
            finally
            {

                currentPostingThreadState.isPosting = false;
            }
        }
    }

    private void PostSingleEvent(object notification, PostingThreadState postingState)
    {
        Type eventClass = notification.GetType();
        bool subscriptionFound = false;
        subscriptionFound = PostSingleEventForEventType(notification, postingState, eventClass);
    }

    private bool PostSingleEventForEventType(object notification, PostingThreadState postingState, Type eventClass)
    {
        List<Subscription> subscriptions;
        subscriptionsByEventType.TryGetValue(eventClass, out subscriptions);
        if (subscriptions != null && subscriptions.Count > 0)
        {
            foreach (Subscription subscription in subscriptions)
            {
                postingState.notification = notification;
                postingState.subscription = subscription;
                bool aborted = false;
                try
                {
                    postToSubscription(subscription, notification);
                    aborted = postingState.canceled;
                }
                finally
                {
                    postingState.notification = null;
                    postingState.subscription = null;
                    postingState.canceled = false;
                }
                if (aborted)
                {
                    break;
                }
            }
            return true;
        }
        return false;
    }

    private void postToSubscription(Subscription subscription, object notification)
    {
        invokeSubscriber(subscription, notification);
    }

    void invokeSubscriber(Subscription subscription, object notification)
    {
        object[] parameters = new object[1];
        parameters[0] = notification;
        subscription.subscriberMethod.method.Invoke(subscription.subscriber, parameters);
    }

    private List<Type> LookupAllEventTypes(Type eventClass)
    {
        List<Type> eventTypes;
        sEventTypesCache.TryGetValue(eventClass, out eventTypes);
        if (eventTypes == null)
        {
            eventTypes = new List<Type>();
            Type clazz = eventClass;
            while (clazz != null)
            {
                eventTypes.Add(clazz);
                AddInterfaces(eventTypes, clazz.GetInterfaces());
                clazz = clazz.BaseType;
            }
            sEventTypesCache.Add(eventClass, eventTypes);
        }
        return eventTypes;
    }

    private void AddInterfaces(List<Type> eventTypes, Type[] interfaces)
    {
        foreach (Type interfaceClass in interfaces)
        {
            if (!eventTypes.Contains(interfaceClass))
            {
                eventTypes.Add(interfaceClass);
                AddInterfaces(eventTypes, interfaceClass.GetInterfaces());
            }
        }
    }

    class PostingThreadState
    {
        public readonly List<object> eventQueue = new List<object>();
        public bool isPosting;
        public Subscription subscription;
        public object notification;
        public bool canceled;
    }
}