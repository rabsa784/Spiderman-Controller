using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Credits for jumping: https://discussions.unity.com/t/how-to-make-a-simple-jump-script-in-3d-c/167962/3

public class Controller : MonoBehaviour
{
    //PSEDO CODE: Declare float variables for speed, maxspeed, acceleration, deceleration, rotation

    private Rigidbody rb;
    public float jumpHeight = 15.0f;

    public float speed = 5.0f;
    public float maxspeed = 15.0f;
    public float maxrunspeed = 35.0f;
    public float acc = 1.0f;
    public float dec = 1.0f;
    public float rotation = 0.0f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {

    //PSEUDO CODE: Check for space key input. If not max speed, accelerate, else decelerate
    if (Input.GetKey(KeyCode.W))
    {
        //accelerate
        if(speed < maxspeed)
            speed += acc;
            //speed = speed + acc;
    }
    else
    {
        //decelerate
        if (speed > 0)
            speed -= dec;
            //speed = speed - dec;
    }


    //PSEUDO CODE: Use the speed and transform to move the object forward

    //FUNCTION: Simplist transform with ACC, DEC, Speed (Space bar), and TDT
    transform.position += transform.forward * Time.deltaTime * speed;
    //PSEUDO CODE: Check for Left and Right Key inputs. Turn if left or right keys are pressed
    if ((Input.GetKey(KeyCode.A)))
    {
        transform.Rotate(0, -0.4f, 0);
    }
    if ((Input.GetKey(KeyCode.D)))
    {
        transform.Rotate(0, 0.4f, 0);
    }
    if ((Input.GetKey(KeyCode.LeftShift)))
    {
        speed = maxrunspeed;
    }
    else
    {
        if(speed == maxrunspeed)
            speed = maxspeed;
    }

    }

    void FixedUpdate()
    {
        //Jump with Physics
        if ((Input.GetButton("Jump")))
        {
            rb.AddForce(Vector3.up * jumpHeight * 2);
        }
    }

}