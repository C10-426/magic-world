using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AttackController : MonoBehaviour, IPointerClickHandler {

	public event Action OnAttackClicked;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void IPointerClickHandler.OnPointerClick(PointerEventData eventData) {
		if (OnAttackClicked != null) {
			OnAttackClicked ();
		}
	}
}
