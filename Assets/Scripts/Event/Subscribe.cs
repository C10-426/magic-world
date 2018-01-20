
using System;

[AttributeUsage(AttributeTargets.Method)]
public class Subscribe : Attribute
{
    private int priority = 0;

    public Subscribe()
    {
        priority = 0;
    }

    public Subscribe(int priority)
    {
        this.priority = priority;
    }

    public int Priority
    {
        get
        {
            return priority;
        }

        set
        {
            priority = value;
        }
    }
}