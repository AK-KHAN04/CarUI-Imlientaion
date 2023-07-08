using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform car;
    public float speed = 10;
    public Button accerlerator, brake;
    public GameObject steering;
    public float i;
    public GameObject frontWheel1, frontWheel2;

    private bool acceratordown;
    private bool brakeDown;

    public GameObject Lights;

    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);


    private void Start()
    {
        frontWheel1.transform.localRotation = Quaternion.Euler(0, 0, 0);
        frontWheel2.transform.localRotation = Quaternion.Euler(0, 0, 0);
    }

    private void Update()
    {
        
    }



    void FixedUpdate()
    {
        i = steering.GetComponent<SteeringWheel>().OutPut;

        if (Input.GetKey("w") || acceratordown)
        {
            forwardMove();
        }
        if (Input.GetKey("s") || brakeDown)
        {
            BackwardMove();
        }

        if (Input.GetKey(KeyCode.A))
        {
          //  i = -1;
        }

        if (Input.GetKey((KeyCode.A)) || i<0)
        {
            RotateLeft();
            frontWheel1.transform.localRotation = Quaternion.Euler(0, -30, 0);
            frontWheel2.transform.localRotation = Quaternion.Euler(0, -30, 0);
        }

        else if (Input.GetKey("d") || i > 0)
        {
            
            RotateRight();
            frontWheel1.transform.localRotation = Quaternion.Euler(0, 30, 0);
            frontWheel2.transform.localRotation = Quaternion.Euler(0, 30, 0);
        }
        else
        {
            frontWheel1.transform.localRotation = Quaternion.Euler(0, 0, 0);
            frontWheel2.transform.localRotation = Quaternion.Euler(0, 0, 0);
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


    public void Rotate()
    {

    }
}
