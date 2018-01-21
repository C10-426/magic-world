using System;

public class SkillData 
{
    private int id;
    private float cd;
    private float damage;
    private string trigger;

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
        }
    }

    public float Cd
    {
        get
        {
            return cd;
        }

        set
        {
            cd = value;
        }
    }

    public float Damage
    {
        get
        {
            return damage;
        }

        set
        {
            damage = value;
        }
    }

    public string Trigger
    {
        get
        {
            return trigger;
        }

        set
        {
            trigger = value;
        }
    }
}
