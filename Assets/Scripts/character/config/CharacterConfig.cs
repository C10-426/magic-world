using GameGeek.Character;
public class CharacterConfig
{
    public static CharacterProperty GetDefaultCharacterProperty()
    {
        CharacterProperty property = new CharacterProperty();
        property.level = 1;
        // property.hpMaxLimit = 100;
        // property.mpMaxLimit = 80;
        // property.hp = property.hpMaxLimit;
        // property.mp = property.mpMaxLimit;
        property.hp = 100;
        property.mp = 80;
        property.atk = 20;
        // property.atkRange = 1.0f;
        // property.defense = 12;
        // property.moveSpeed = 0.6f;
        return property;
    }
}