using UnityEngine;
using System.Collections.Generic;
public class MonsterManager
{
    private static MonsterManager sInstance;
    private static int increamentId = 1;
    Dictionary<int, Character> pool;


    private MonsterManager()
    {
        pool = new Dictionary<int, Character>(10);
    }


    public static MonsterManager GetInstance()
    {
        if (sInstance == null)
        {
            sInstance = new MonsterManager();
        }
        return sInstance;
    }

    public void AddMonster(Character monster)
    {
        if (!pool.ContainsValue(monster))
        {
            increamentId++;
            pool.Add(increamentId, monster);
        }
    }

    public Character GetMonster(int monsterId)
    {
        if (pool.ContainsKey(monsterId))
        {
            return pool[monsterId];
        }
        return null;
    }
}