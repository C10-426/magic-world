using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GameGeek.Character;

public class Character : MonoBehaviour {

	protected CharacterType characterType;
	protected CharacterProperty property;
	protected Equipments equipments;

	protected List<Skill> skills;

	public Character()
	{
		characterType = CharacterType.CT_NULL;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool InSight(Transform target)
	{
		return TargetDetector.InSight(this.gameObject.transform, target);
	}

	public void Attack(GameObject target)
	{
		
	}

	public void CastSkill(int skillId, GameObject target)
	{

	}
}
