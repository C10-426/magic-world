using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SkillBaseController : MonoBehaviour, IPointerClickHandler {

    private SkillData skillData;
    public event Action<SkillData> OnSkillClicked;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void setSkillData(SkillData data) {
        this.skillData = data;
    }

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        if (OnSkillClicked != null)
        {
            OnSkillClicked(skillData);
        }
    }
}
