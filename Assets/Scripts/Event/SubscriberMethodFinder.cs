
using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class SubcriberMethodFinder
{
    private static readonly Dictionary<Type, List<SubscriberMethod>> METHOD_CACHE = new Dictionary<Type, List<SubscriberMethod>>();

    public List<SubscriberMethod> FindSubscriberMethods(Type subscriberClass)
    {
        List<SubscriberMethod> subscriberMethods;
        if (METHOD_CACHE.TryGetValue(subscriberClass, out subscriberMethods))
        {
            return subscriberMethods;
        }

        subscriberMethods = FindByReflectin(subscriberClass);
        if (subscriberMethods == null)
        {
            throw new EventException("Subscriber " + subscriberClass
                    + " and its super classes have no public methods with the @Subscribe attribute");
        }
        METHOD_CACHE.Add(subscriberClass, subscriberMethods);
        return subscriberMethods;
    }

    private List<SubscriberMethod> FindByReflectin(Type subscriberClass)
    {
        List<SubscriberMethod> subscriberMethods = null;
        MethodInfo[] methods = subscriberClass.GetMethods();
        foreach (MethodInfo method in methods)
        {
            Subscribe subscribeAttribute = Attribute.GetCustomAttribute(method, typeof(Subscribe)) as Subscribe;
            if (subscribeAttribute != null)
            {
                if (subscriberMethods == null)
                {
                    subscriberMethods = new List<SubscriberMethod>();
                }
                Type eventType = method.GetParameters()[0].ParameterType;
                subscriberMethods.Add(new SubscriberMethod(method, eventType, subscribeAttribute.Priority));
            }
        }
        return subscriberMethods;
    }
}