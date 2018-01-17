
using GameGeek.Character;

public class IdleAppear : Appear {

    public IdleAppear()
    {
        appearStatus = AppearStatus.AS_IDLE;
        animationName = "Idle";
    }

}