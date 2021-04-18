using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController controller;
    private float speed = 0.5f;
    private float rx = 0f, ry;
    private float angularSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx, dz;

        //mouse to rotate player
        rx = transform.localEulerAngles.x + Input.GetAxis("Mouse Y") * angularSpeed;
        ry = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * angularSpeed;

        transform.localEulerAngles = new Vector3(rx, ry, 0);//sets the new orientation of player

        //keyboard

        dx = Input.GetAxis("Horizontal") * speed;//Horizontal means 'A' or 'D'
        dz = Input.GetAxis("Vertical") * speed; // Vertical means 'W' or 'S'

        Vector3 motion = new Vector3(dx, 0, dz);

        motion = transform.TransformDirection(motion);//in global coordinates
        controller.Move(motion);

    }
}
