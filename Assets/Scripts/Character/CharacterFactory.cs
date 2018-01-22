


using System.Collections.Generic;
using GameGeek.Character;

public class CharacterFactory : ObjectInstance<CharacterFactory>, IFactory<Character>
{
    private readonly Dictionary<int, CharacterProperty> dataSource;

    public CharacterFactory()
    {
        dataSource = new Dictionary<int, CharacterProperty>();
        LoadConfig();
    }


    public void LoadConfig()
    {
        
    }

    public Character Create(int id)
    {
        Character character = new Character();
        dataSource.TryGetValue(id, out character.property);
        return character;
    }


    
}