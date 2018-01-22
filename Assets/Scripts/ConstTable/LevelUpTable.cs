using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConstantData
{
    public struct LevelUpData
    {
        public int requiredXP;

        public LevelUpData(int xp)
        {
            this.requiredXP = xp;
        }
    }

    public class LevelUpTable
    {
        /**
         * Data dictionary, storing the data of level up
         */
        private static Dictionary<int, LevelUpData> table = new Dictionary<int, LevelUpData>();

        private static readonly int LEVEL_UP_ERROR_CODE = -1;
        /* 
         * The fixed columns count of LevelUpData. They are:
         * level(key), requiredXP
         */
        private static readonly int LEVEL_UP_COLUMN_COUNT = 2;

        private LevelUpTable() { }

        public static void ReadData(List<string[]> data)
        {
            table.Clear();
            for (int i = 0; i < data.Count; i++)
            {
                string[] dataRow = data[i];
                if (dataRow.Length != LEVEL_UP_COLUMN_COUNT)
                {
                    continue;
                }
                // initial data
                int levelKey = LEVEL_UP_ERROR_CODE;
                LevelUpData levelUpData = new LevelUpData(LEVEL_UP_ERROR_CODE);
                // read data row
                for (int column = 0; column < dataRow.Length; column++)
                {
                    switch (column)
                    {
                        case 0:
                            levelKey = int.Parse(dataRow[column]);
                            break;
                        case 1:
                            levelUpData.requiredXP = int.Parse(dataRow[column]);
                            break;
                        default:
                            break;
                    }
                }
                if (levelUpData.requiredXP != LEVEL_UP_ERROR_CODE)
                {
                    table.Add(levelKey, levelUpData);
                }
            }
        }

        public static LevelUpData GetLevelUpData(int level)
        {
            LevelUpData result;
            if (table.TryGetValue(level, out result))
            {
                return result;
            }
            throw new NullReferenceException();
        }

        //private static Dictionary<int, float> table = new Dictionary<int, float>() {
        //    {2, 100},
        //    {3, 300},
        //    {4, 600},
        //    {5, 1000},
        //    {6, 1500},
        //    {7, 2500},
        //    {8, 4000},
        //    {9, 6000},
        //    {10, 10000}
        //};

        //public static readonly float LEVEL_UP_TABLE_ERROR = -1;

        //public static float getRequiredXP(int level) {
        //    float result;
        //    if (table.TryGetValue(level, out result)) {
        //        return result;
        //    } else {
        //        return LEVEL_UP_TABLE_ERROR;
        //    }
        //}
    }
}
