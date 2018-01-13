using GameGeek.Character;
public class CharacterPlayer : Character
{

    public CharacterPlayer()
    : base()
    {
        property = CharacterConfig.GetDefaultCharacterProperty();
    }
}