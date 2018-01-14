using GameGeek.Character;
public class Player : CharacterPlayer
{


    private static Player sInstance;

    public Player()
    {
        name = "Sun Of Beach";
        if (sInstance != null) {
            throw new System.Exception("player has bean created");
        }
        sInstance = this;
    }

    public static Player GetInstance()
    {
        if (sInstance == null)
        {
            sInstance = new Player();
        }
        return sInstance;
    }

}