using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float ZOffset;

    private Vector3 offsetOfPlayerAndCamara;

    // Use this for initialization
    void Start()
    {
        offsetOfPlayerAndCamara = transform.position - target.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        // Vector3 targetpos = new Vector3(target.position.x, target.position.y + transform.position.y, target.position.z + ZOffset);

        transform.position = target.position + offsetOfPlayerAndCamara;
    }
}
