using GameGeek.Character;
using UnityEngine;

public class Skill
{
    private Character owner;
    private string resName;
    public SkillType type;
    public SkillData property;

    private SkillAppear appear;

    public string ResName
    {
        get
        {
            return resName;
        }

        set
        {
            resName = value;
        }
    }

    public Character Owner
    {
        get
        {
            return owner;
        }

        set
        {
            owner = value;
        }
    }

    public SkillAppear Appear
    {
        get
        {
            return appear;
        }

        set
        {
            appear = value;
        }
    }

    public Skill()
    {
        property = new SkillData();
    }

    public Skill(int skillId)
    {
        property = new SkillData();
        property.Id = skillId;
    }

    public Skill(Character owner, int skillId)
    {
        Owner = owner;
        property = new SkillData();
        property.Id = skillId;
    }

    public bool IsNormalAttack()
    {
        // TODO @Leo
        return true;
    }

    public SkillAppear create(int skillId)
    {
        SkillAppear appear = new SkillAppear();
        appear.SetOwner(owner);
        return appear;
    }

    public void Execute()
    {
        Animator animator = owner.GetComponent<Animator>();
        if (animator != null)
        {
            animator.SetTrigger(property.Trigger);
        }
    }

}

