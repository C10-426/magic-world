using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5;
    public Joystick moveJoy;
    //public Transform gun;

    private Rigidbody player;
	private Animation animations;

    void Start()
    {
        player = GetComponent<Rigidbody>();
		animations = GetComponent<Animation> ();
		moveJoy.OnStartJoystickMovement += HandleStartMovement;
		moveJoy.OnJoystickMovement += HandleMovement;
		moveJoy.OnEndJoystickMovement += HandleEndMovement;
    }

    void FixedUpdate()
    {
        if (moveJoy != null)
        {
            player.velocity = moveJoy.MoveInput() * speed;           //Move rigidbody;
            moveJoy.Rotate(transform, 15.0F);                           //Rotate rigidbody;
            //moveJoy.Rotate(gun, 15.0F);								//Rotate gun;
        }
    }

	void HandleStartMovement(Joystick sender, Vector2 vector)
	{
		if (moveJoy != null && animations != null) {
			if (!animations.IsPlaying ("RunFront")) {
				animations.Stop ();
				animations.Play ("RunFront");
			}
		}
	}

	void HandleEndMovement(Joystick sender, Vector2 vector) 
	{
		if (moveJoy != null && animations != null) {
			if (!animations.IsPlaying ("Idle")) {
				animations.Stop ();
				animations.Play ("Idle");
			}
		}
	}

	void HandleMovement (Joystick sender, Vector2 vector)
	{
		if (moveJoy != null && animations != null) {
			if (!animations.IsPlaying("RunFront")) {
				animations.Stop ();
				animations.Play ("RunFront");
			}
		}
	}
}
