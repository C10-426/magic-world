using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * Basic information of a skill button
 */
struct SkillUI
{
    // position
    private float positionX;
    private float positionY;
    // image path relative to '/Resources'
    private string imageName;
    // initialize function
    public void init(float x, float y, string name) {
        positionX = x;
        positionY = y;
        imageName = name;
    }
    // getter
    public float getPositionX() {
        return positionX;
    }
    public float getPositionY() {
        return positionY;
    }
    public string getImageName() {
        return imageName;
    }
};

public class PlayerSkillsController : MonoBehaviour
{

	public GameObject skillPrefab;

	[HideInInspector]
	private List<GameObject> activeSkills;

    private List<SkillUI> skillUIs;

    /*
     * Constant for positioning the Skill UI.
     */
    private static readonly int ATTACK_X = 440;
    private static readonly int ATTACK_Y = 60;
    private static readonly int ATTACK_UI_RADIUS = 40;
    private static readonly int SKILL_UI_RADIUS = 25;
    private static readonly Vector2[] SKILL_POSITION = {
        new Vector2(ATTACK_X, ATTACK_Y + ATTACK_UI_RADIUS + SKILL_UI_RADIUS),
        new Vector2(ATTACK_X - ATTACK_UI_RADIUS - SKILL_UI_RADIUS, ATTACK_Y),
        new Vector2(ATTACK_X, ATTACK_Y + ATTACK_UI_RADIUS + 3 * SKILL_UI_RADIUS),
        new Vector2(ATTACK_X - ATTACK_UI_RADIUS - 3 * SKILL_UI_RADIUS, ATTACK_Y)
    };

    private void Initialize() {
        activeSkills = new List<GameObject>();
        skillUIs = new List<SkillUI>();
    }

	// Use this for initialization
	void Start () {
        // init
        this.Initialize();

        // fake data
        for (int i = 0; i < 2; i++) {
            SkillUI skillUI = new SkillUI();
            skillUI.init(SKILL_POSITION[i].x, SKILL_POSITION[i].y, 
                         "texture_s" + (i + 1).ToString());
            skillUIs.Add(skillUI);
        }

        // generate ui
        for (int i = 0; i < 2; i++) {
            SkillUI skillUI = skillUIs[i];
            this.InitSingleSkillPrefab(
                new Vector2(skillUI.getPositionX(), skillUI.getPositionY()), skillUI.getImageName(), i);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void InitSingleSkillPrefab(Vector2 position, string imagePath, int skillID) {
        GameObject skillObject = (GameObject)GameObject.Instantiate(skillPrefab);
        SkillBaseController skillBaseController = skillObject.GetComponent<SkillBaseController>();
        if (!InitSkillData(ref skillBaseController, skillID)) {
            return;
        }
		skillObject.transform.SetParent (this.transform);
        Vector3 positionV3 = new Vector3(position.x, position.y, 0);
        skillObject.transform.localPosition = positionV3;
        Sprite sprite = Resources.Load("Textures/Skills/" + imagePath, typeof(Sprite)) as Sprite;
        skillObject.GetComponent<Image>().sprite = sprite;
		activeSkills.Add (skillObject);
	}

    private bool InitSkillData(ref SkillBaseController skillBaseController, int skillID) {
        SkillData skillData = this.getSkillData(skillID);
        if (null == skillData) {
            return false;
        }
        skillBaseController.setSkillData(skillData);
        this.AddEventListener(ref skillBaseController);
        return true;
    }

    private void AddEventListener(ref SkillBaseController skillBaseController) {
        skillBaseController.OnSkillClicked += HandleSkillClicked;
    }

    /**
     * This will be replaced by reading real data
     */
    private SkillData getSkillData(int i) {
        switch (i) {
            case 0:
                return SkillManager.Instance().FindOrCreate(SkillManager.SI_SKILL_1).property;
            case 1:
                return SkillManager.Instance().FindOrCreate(SkillManager.SI_SKILL_2).property;
            default:
                break;
        }
        return null;
    }

    /************************ Event Handler ************************/

    void HandleSkillClicked(SkillData skillData) {
        EventBus.GetDefault().Post(new ReleaseSkillEvent(skillData));
    }
}
