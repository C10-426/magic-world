
using GameGeek.Character;
using UnityEngine;

public abstract class AppearManager
{

    public Character owner;
    private Appear current;

    public void ChangeAppear(Appear next)
    {
        if (current != null)
        {
            current.DeactiveAppear();
            Component.Destroy(current);
            current = null;
        }
        current = next;
        if (current != null)
        {
            current.SetOwner(owner);
            current.ActiveAppear();
        }
    }

    public void ChangeAppear(AppearStatus appearStatus)
    {
        ChangeAppear(create(appearStatus));
    }

    protected abstract Appear create(AppearStatus appearStatus);

    protected abstract Appear create(SkillData skillData);

}