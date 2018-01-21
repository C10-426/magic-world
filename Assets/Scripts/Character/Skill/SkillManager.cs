

using System.Collections.Generic;
using GameGeek.Character;
using UnityEngine;

public class SkillManager : ObjectManager<SkillManager, Skill>
{

    public static int SI_ATTACK = 0;
    public static int SI_SKILL_1 = 1;
    public static int SI_SKILL_2 = 2;
    private readonly SkillFactory factory;

    public SkillManager()
    {
        factory = SkillFactory.GetInstance();
    }

    public override Skill CreateObject(int id)
    {
        return factory.Create(id);
    }

    public void ReleaseSkill(Character owner, int id)
    {
        Skill skill = FindOrCreate(id);
        skill.Owner = owner;
        skill.Execute();
    }
}