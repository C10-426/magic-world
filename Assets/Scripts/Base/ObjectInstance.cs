


using System;
using System.Collections.Generic;
using GameGeek.Character;

public abstract class ObjectInstance<T> where T : new()
{
    private static T sInstance;

    public static T Instance()
    {
        if (sInstance == null)
        {
            sInstance = new T();
        }
        return sInstance;
    }

}


