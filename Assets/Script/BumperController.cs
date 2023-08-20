using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public float score;
    //Storing Ball refenrence for checking
    public Collider ball;

    //Adding Speed when Collide
    public float multiplier;

    //Set Bumper Color
    public Color color;

    //Render Component In Object 
    private Renderer renderer;

    //Animator Reference
    private Animator animator;

    public AudioManager audioManager;

    public VFXManager vfxManager;

    public ScoreManager scoreManager;

    private void Start()
    {
        //Get Render
        renderer = GetComponent<Renderer>();

        //Get Animator
        animator = GetComponent<Animator>();


        //Acces Material and change the color
        renderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Check Collision WIth Ball
        if(collision.collider == ball)
        {
            Debug.Log("Hit");

            //Take Ball RIgidbody and mult the speed
            Rigidbody ballRig = ball.GetComponent<Rigidbody>();
            ballRig.velocity *= multiplier;

            //Play Animation When Hit
            animator.SetTrigger("hit");

            audioManager.PlaySFX(collision.transform.position);
            vfxManager.PlayVFX(collision.transform.position);

            scoreManager.AddScore(score);

        }
    }
}
