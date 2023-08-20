using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    //Set Maximum Ball Speed
    public float maxSpeed;

    private Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //Check Speed
        if(rig.velocity.magnitude > maxSpeed)
        {
            //If Velocity > MaxSpeed
            rig.velocity = rig.velocity.normalized * maxSpeed;
        }
    }
}
