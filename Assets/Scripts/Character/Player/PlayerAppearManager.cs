

using GameGeek.Character;

public class PlayerAppearManager : AppearManager
{
    protected PlayerAppearManager()
    {
    }

    protected override Appear create(AppearStatus appearStatus)
    {
        switch (appearStatus)
        {
            case AppearStatus.AS_IDLE:
                return new IdleAppear(appearStatus, "Idle");
            case AppearStatus.AS_MOVE:
                return new MoveAppear(appearStatus, "RunFront");
                case AppearStatus.AS_ATTACK:
                return new IdleAppear(appearStatus, "AttackM");
            default:
                return null;
        }
    }

    protected override Appear create(SkillData skillData)
    {
        throw new System.NotImplementedException();
    }
}