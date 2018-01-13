using GameGeek.Character;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMonster : Character
{

    private NavMeshAgent navMeshAgent;

    public CharacterMonster()
    : base()
    {
        characterType = CharacterType.CT_MONSTER;
        Init();
    }

    private void Init()
    {
        property = CharacterConfig.GetDefaultCharacterProperty();
        MonsterManager.GetInstance().AddMonster(this);
        skills = new List<Skill>();
        skills.Add(new Skill(this, "attack1"));
        skills.Add(new Skill(this, "attack2"));
        skills.Add(new Skill(this, "hit1"));
        skills.Add(new Skill(this, "hit2"));

        // patrol
        // navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Start()
    {
        Animation animation = GetComponent<Animation>();
        animation.Play("attack1");
    }

    void FixedUpdate()
    {
        Animation animation = GetComponent<Animation>();
        if (!animation.isPlaying) {
            animation.Play("attack2");
        }
    }

    public void Patrol()
    {

    }
}