
using System;
using System.Reflection;

public class SubscriberMethod
{

    public readonly MethodInfo method;
    public readonly Type eventType;
    public readonly int priority;

    public readonly string methodString;

    public SubscriberMethod(MethodInfo method, Type eventType, int priority)
    {
        this.method = method;
        this.eventType = eventType;
        this.priority = priority;
    }

}