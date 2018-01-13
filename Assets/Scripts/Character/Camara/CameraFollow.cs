using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public Joystick joystick;

    public float zoomSpeed = 30; //镜头缩放速率
    public float rotateSpeed = 1; //镜头旋转速率
    public float distance = 15; //设置距离角色的距离
    private Vector3 camaraAngle = new Vector3(-0.5f, 0.7f, -0.5f); // result of transform.rotation * Vector3.back

    private Vector3 offsetOfPlayerAndCamara;

    // Use this for initialization
    void Start()
    {
        transform.position = camaraAngle * distance + target.transform.position;
        joystick.Rotate(transform.rotation.x);
        UpdateCamara();
    }

    void UpdateCamara()
    {
        float delta_rotation_x, delta_rotation_y;
        if (Input.GetAxis("Mouse ScrollWheel") != 0) //通过滑动缩放视野
            distance += -Input.GetAxis("Mouse ScrollWheel") * zoomSpeed;

        if (Input.GetMouseButton(1))
        {
            delta_rotation_x = Input.GetAxis("Mouse X") * rotateSpeed;
            delta_rotation_y = -Input.GetAxis("Mouse Y") * rotateSpeed;
            transform.Rotate(0, delta_rotation_x, 0, Space.World);
            transform.Rotate(delta_rotation_y, 0, 0);
            joystick.Rotate(transform.rotation.x);
        }
        transform.position = camaraAngle * distance + target.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateCamara();
    }
}
