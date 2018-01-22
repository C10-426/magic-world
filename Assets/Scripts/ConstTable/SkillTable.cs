using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConstantData
{
    public struct SkillData {
        int skillID;
        int level;
        string name;
        // 类型：对自己or敌人释放
        int type;
        // 增益效果 key:增益类型 value:增益值
        Dictionary<int, float> effect;
        float cd;
        float range;
        float releaseTime;
        float cdLimit;
    }

    public class SkillTable {
    }

}