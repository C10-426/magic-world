


using System;
using System.Collections.Generic;
using GameGeek.Character;

public abstract class ObjectManager<M, T> : IManager<T> where M : IManager<T>, new() where T : new()
{
    private static M sInstance;
    private int incrementalId = 0;
    private readonly Dictionary<int, T> objPool = new Dictionary<int, T>();

    public ObjectManager()
    {
    }

    public static M GetInstance()
    {
        if (sInstance == null)
        {
            sInstance = new M();
        }
        return sInstance;
    }

    public T Create(int id)
    {
        T obj = CreateObject(id);
        objPool[id] = obj;
        return obj;
    }

    public abstract T CreateObject(int id);

    public void Remove(int id)
    {
        T obj;
        if (objPool.TryGetValue(id, out obj))
        {
            objPool.Remove(id);
        }
    }

    public T Find(int id)
    {
        T obj;
        objPool.TryGetValue(id, out obj);
        return obj;
    }

    public T FindOrCreate(int id)
    {
        T obj = Find(id);
        if (obj == null)
        {
            UnityEngine.Debug.Log("can't find obj , id = " + id +" , and then create it.");
            obj = Create(id);
        }
        return obj;
    }

}


