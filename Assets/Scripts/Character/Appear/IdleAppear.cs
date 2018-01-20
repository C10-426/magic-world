
using GameGeek.Character;

public class IdleAppear : Appear
{
    public IdleAppear(AppearStatus appearStatus, string animationName)
    {
        this.appearStatus = appearStatus;
        this.animationName = animationName;
    }
}