using GameGeek.Character;

public class Skill
{
    private Character owner;
    private string resName;
    public SkillType type;
    public SkillProperty property;

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

    public Skill(Character owner, string resName)
    {
        Owner = owner;
        ResName = resName;
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
}