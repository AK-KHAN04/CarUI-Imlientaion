using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform car;
    public float speed = 10;
    public Button accerlerator, brake;

    private bool acceratordown;
    private bool brakeDown;

    public GameObject steering;

  

    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);

    private void Start()
    {
       
    }

    private void Update()
    {
        
    }



    void FixedUpdate()
    {
        if (Input.GetKey("w") || acceratordown)
        {
            forwardMove();
        }
        if (Input.GetKey("s") || brakeDown)
        {
            BackwardMove();
        }

        if (Input.GetKey("d"))
        {
            RotateRight();
        }

        if (Input.GetKey("a"))
        {
            RotateLeft();
        }  
    }

   
   public void forwardMove()
    {
        transform.Translate(forward * speed * Time.deltaTime);

    }

    public void BackwardMove()
    {
        transform.Translate(backward * speed * Time.deltaTime);

    }

    public void RotateLeft()
    {
        Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotationLeft);
        steering.transform.rotation = Quaternion.Euler(0, 0, 10);
    }

    public void RotateRight()
    {
        Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
        rb.MoveRotation(rb.rotation * deltaRotationRight);
    }

    public void AccUp()
    {
        acceratordown = false;
    }

    public void AccDown()
    {
        acceratordown = true;
    }

    public void BrakeUp()
    {
        brakeDown = false;
    }

    public void BrakeDown()
    {
        brakeDown = true;
    }

}
