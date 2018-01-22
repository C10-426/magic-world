﻿// -------------------------------------------------------------------------------
// THIS FILE IS ORIGINALLY GENERATED BY THE DESIGNER.
// YOU ARE ONLY ALLOWED TO MODIFY CODE BETWEEN '///<<< BEGIN' AND '///<<< END'.
// PLEASE MODIFY AND REGENERETE IT IN THE DESIGNER FOR CLASS/MEMBERS/METHODS, ETC.
// -------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

///<<< BEGIN WRITING YOUR CODE FILE_INIT

///<<< END WRITING YOUR CODE

namespace GameGeek.Character
{
///<<< BEGIN WRITING YOUR CODE NAMESPACE_INIT

///<<< END WRITING YOUR CODE

	public class CharacterMonster : GameGeek.Character.Character
///<<< BEGIN WRITING YOUR CODE CharacterMonster
///<<< END WRITING YOUR CODE
	{
///<<< BEGIN WRITING YOUR CODE CLASS_PART

	public List<Skill> skills;
		public CharacterMonster()
    : base()
    {
        characterType = CharacterType.CT_MONSTER;
        InitCharacterMonster();
    }

	 private void InitCharacterMonster()
    {
        property = CharacterConfig.GetDefaultCharacterProperty();
        MonsterManager.GetInstance().AddMonster(this);
        skills = new List<Skill>();
        skills.Add(SkillFactory.Instance().Create(1));
        skills.Add(SkillFactory.Instance().Create(2));
        skills.Add(SkillFactory.Instance().Create(3));
        skills.Add(SkillFactory.Instance().Create(4));

        // patrol
        // navMeshAgent = GetComponent<NavMeshAgent>();
    }

///<<< END WRITING YOUR CODE

	}

///<<< BEGIN WRITING YOUR CODE NAMESPACE_UNINIT

///<<< END WRITING YOUR CODE
}

///<<< BEGIN WRITING YOUR CODE FILE_UNINIT

///<<< END WRITING YOUR CODE

