
using GameGeek.Character;
using UnityEngine;

public class AppearManager
{

    public Character owner;
    private Appear current;

    public AppearManager()
    {
    }

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
        switch (appearStatus)
        {
            case AppearStatus.AS_IDLE:
                ChangeAppear(new IdleAppear());
                break;
            case AppearStatus.AS_MOVE:
                ChangeAppear(new MoveAppear());
                break;
        }
    }

}