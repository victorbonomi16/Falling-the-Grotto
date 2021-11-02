using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoviment : MonoBehaviour
{
    public Rigidbody2D carRig;
    public Rigidbody2D backWheelRig;
    public Rigidbody2D frontWheelRig;
    
    public float speed;
    public float torque;

    private float movement;
    

    void Update()
    {
        movement = Input.GetAxis("Horizontal"); 
    }

    private void FixedUpdate()
    {
        backWheelRig.AddTorque(-movement * speed * Time.fixedDeltaTime);
        frontWheelRig.AddTorque(-movement * speed * Time.fixedDeltaTime);
        carRig.AddTorque(-movement * torque * Time.fixedDeltaTime);
    }
}
