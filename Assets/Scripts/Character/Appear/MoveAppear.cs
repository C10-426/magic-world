
using GameGeek.Character;

public class MoveAppear : Appear
{
    public MoveAppear(AppearStatus appearStatus, string animationName)
    {
        this.appearStatus = appearStatus;
        this.animationName = animationName;
    }
}