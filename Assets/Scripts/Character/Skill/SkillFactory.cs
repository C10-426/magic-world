

using System.Collections.Generic;

public class SkillFactory : IFactory<Skill>
{
    private static SkillFactory sInstance;
    private readonly Dictionary<int, SkillData> dataSource;

    private SkillFactory()
    {
        dataSource = new Dictionary<int, SkillData>();
        LoadConfig();
    }

    public static SkillFactory GetInstance()
    {
        if (sInstance == null)
        {
            sInstance = new SkillFactory();
        }
        return sInstance;
    }

    public void LoadConfig()
    {
        LoadPlayerAttack();
        LoadPlayerSkill1();
        LoadPlayerSkill2();
    }

    public Skill Create(int skillId)
    {
        Skill skill = new Skill();
        dataSource.TryGetValue(skillId, out skill.property);
        return skill;
    }


    private void LoadPlayerAttack()
    {
        SkillData skillData = new SkillData();
        skillData.Id = SkillManager.SI_ATTACK;
        skillData.Cd = 1.5f;
        skillData.Damage = 10;
        skillData.Trigger = "Attack";
        dataSource.Add(skillData.Id, skillData);
    }

    private void LoadPlayerSkill1()
    {
        SkillData skillData = new SkillData();
        skillData.Id = SkillManager.SI_SKILL_1;
        skillData.Cd = 3f;
        skillData.Damage = 10;
        skillData.Trigger = "Skill_1";
        dataSource.Add(skillData.Id, skillData);
    }

    private void LoadPlayerSkill2()
    {
        SkillData skillData = new SkillData();
        skillData.Id = SkillManager.SI_SKILL_2;
        skillData.Cd = 3.5f;
        skillData.Damage = 10;
        skillData.Trigger = "Skill_2";
        dataSource.Add(skillData.Id, skillData);
    }
}