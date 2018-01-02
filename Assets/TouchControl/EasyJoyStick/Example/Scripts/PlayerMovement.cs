using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5;
    public Joystick moveJoy;
    //public Transform gun;

    private Rigidbody player;

    void Start()
    {
        player = GetComponent<Rigidbody>();
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

}
