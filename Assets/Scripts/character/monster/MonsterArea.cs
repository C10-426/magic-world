using UnityEngine;
using System.Collections.Generic;

namespace GameGeek.Character
{
    public class MonsterArea
    {
        List<Vector3> spawnPoint1;
        List<Vector3> spawnPoint2;
        List<Vector3> spawnPoint3;
        List<Vector3> spawnPoint4;

        public MonsterArea()
        {
            spawnPoint1 = new List<Vector3>();
            spawnPoint2 = new List<Vector3>();
            spawnPoint3 = new List<Vector3>();
            spawnPoint4 = new List<Vector3>();
        }
    }
}
