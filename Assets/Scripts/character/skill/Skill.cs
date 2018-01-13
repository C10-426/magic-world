using GameGeek.Character;

public class Skill
{
    private Character _owner;
    private string _resName;
    public SkillType type;
    public SkillProperty property;

    public string ResName
    {
        get
        {
            return _resName;
        }

        set
        {
            _resName = value;
        }
    }

    public Character Owner
    {
        get
        {
            return _owner;
        }

        set
        {
            _owner = value;
        }
    }

    public Skill(Character owner, string resName)
    {
        _owner = owner;
        ResName = resName;
    }

    
}