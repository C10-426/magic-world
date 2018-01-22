

using System.Collections.Generic;
using GameGeek.Character;
using UnityEngine;

public class CharacterManager : ObjectManager<CharacterManager, Character>
{
    private Transform characterRoot;

    public CharacterManager()
    {
        characterRoot = new GameObject("CharacterRoot").transform;
    }

    public override Character CreateObject(int id)
    {
        GameObject characterGO = new GameObject(id.ToString());
        Character character = characterGO.AddComponent<Character>();
        character.property = CharacterConfig.GetDefaultCharacterProperty();
        character.property.id = id;
        characterGO.transform.SetParent(characterRoot);
        return character;
    }

}