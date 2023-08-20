using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider ball; //Ball Reference
    public KeyCode input; //Input For Launch
    public float force; //Launcher Force

    //Set Max Time Hold
    public float maxTimeHold;
    //Set Max Force 
    public float maxForce;

    //Launcher State
    private bool isHold;

    private void Start()
    {
        isHold = false;
    }

    //Can Launch When Ball Touch Launcher
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider == ball)
        {
            ReadInput(ball);
        }
    }

    //Read Input
    private void ReadInput(Collider collider)
    {
        if (Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        //Set Hold True
        isHold = true;

        float force = 0.0f;
        float timeHold = 0.0f;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold / maxTimeHold);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        //If button release, Hold operation end
        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;
    }
}
