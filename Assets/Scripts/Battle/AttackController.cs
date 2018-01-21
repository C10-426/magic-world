using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttackController : MonoBehaviour, IPointerClickHandler {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void IPointerClickHandler.OnPointerClick(PointerEventData eventData) {
		EventBus.GetDefault().Post(new AttackEvent(SkillManager.SI_ATTACK));
	}
}
