using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public KeyCode input;

    //Store Min and Max Pos When pressed
    private float targetPressed;
    private float targetRelease;

    private HingeJoint hinge;

    private void Start()
    {
        //Component Reference
        hinge = GetComponent<HingeJoint>();

        //set Target
        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    // Update is called once per frame
    void Update()
    {
        ReadInput();
        MovePaddle();
    }

    void ReadInput()
    {
        //Component Reference
        //JointSpring jointSpring = GetComponent<HingeJoint>().spring; #1

        //Getting Comp On Start
        JointSpring jointSpring = hinge.spring;

        //Read "input"
        if (Input.GetKey(input))
        {
            //Pressing
            Debug.Log("Pressed");
            jointSpring.spring = targetPressed;
        }
        else
        {
            jointSpring.spring = targetRelease;
        }

        //Getting Reference On Update
        //GetComponent<HingeJoint>().spring = jointSpring; #1

        //Getting Comp On Start
        hinge.spring = jointSpring;
    }

    void MovePaddle()
    {

    }
}
