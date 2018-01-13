using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour {

    public float speed = 5;
    public Joystick moveJoy;
	public AttackController attack;
    public PlayerSkillsController skills;
    //public Transform gun;

    private CharacterController player;
	//private Animation animations;
	private Animator animator;

	// readonly
	//private static readonly string ANIMATION_IDLE = "Idle";
	//private static readonly string ANIMATION_RUN = "RunFront";
	private static readonly string ANIMATOR_RUN = "Run";
	private static readonly string ANIMATOR_ATTACK = "Attack";
	private static readonly string ANIMATOR_IDLE = "Idle";

    void Start()
    {
        player = GetComponent<CharacterController>();
		//animations = GetComponent<Animation> ();
		animator = GetComponent<Animator> ();
        this.AddEventListener();
    }

    void FixedUpdate()
    {
        if (moveJoy != null) {
			Vector3 movement = moveJoy.MoveInput() * speed;
			player.SimpleMove(movement);
            moveJoy.Rotate(transform, 15.0F);                           //Rotate rigidbody; 
        }
    }

    void AddEventListener() {
        // movement
        moveJoy.OnStartJoystickMovement += HandleStartMovement;
        moveJoy.OnJoystickMovement += HandleMovement;
        moveJoy.OnEndJoystickMovement += HandleEndMovement;
        // attack
        attack.OnAttackClicked += HandleAttack;
        // skill
        skills.OnPlayerSkillClicked += HandleSkill;
    }

	void HandleStartMovement(Joystick sender, Vector2 vector)
	{
		if (animator != null) {
			animator.SetBool (ANIMATOR_RUN, true);
		}
	}

	void HandleEndMovement(Joystick sender, Vector2 vector) 
	{
		if (animator != null) {
			animator.SetBool (ANIMATOR_RUN, false);
			animator.SetTrigger (ANIMATOR_IDLE);
		}
	}

	void HandleMovement (Joystick sender, Vector2 vector)
	{
		if (animator != null) {
			animator.SetBool (ANIMATOR_RUN, true);
		}
	}

	void HandleAttack()
	{
		if (animator != null) {
			animator.SetTrigger (ANIMATOR_ATTACK);
		}
	}

    void HandleSkill(SkillData skillData) {
        if (null != skillData.getTrigger()) {
            animator.SetTrigger(skillData.getTrigger());
        }
    }

//	private bool isPlayed(string animatorName)
//	{
//		AnimatorStateInfo animatorInfo = animator.GetCurrentAnimatorStateInfo (0);
//		if (animatorInfo.IsName (animatorName)) {
//			return true;
//		}
//		return false;
//	}
}
