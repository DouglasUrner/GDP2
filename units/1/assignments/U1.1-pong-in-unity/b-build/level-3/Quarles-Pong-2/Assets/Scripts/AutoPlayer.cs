using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPlayer : MonoBehaviour
{
    // Speed of the AI
    public float speed = 2.75f;

    // The ball
    Transform ball;

    // The ball's Rigidbody2D
    Rigidbody2D ballRb;

    //bounds of AI
    public float bound = 4.5f;

    // Use this for initialization
    void Start () {
        //Continuously Invokes Move every x seconds (values may differ)
        InvokeRepeating("Move", .02f, .02f);
    }

    // Movement for the paddle
    void Move () {

        // Finding the ball
        if (ball == null){
            ball = GameObject.FindGameObjectWithTag("Ball").transform;
        }

        // Setting the ball's Rigidbody to a variable
        ballRb = ball.GetComponent<Rigidbody2D>();

        // Checking x direction of the ball
        if(ballRb.velocity.x > 0){

            // Checking y direction of ball
            if(ball.position.y < this.transform.position.y - .3F){
                //move ball down if lower than paddle
                transform.Translate(Vector3.down*speed*Time.deltaTime);
            } else if(ball.position.y > this.transform.position.y + .3F){
                //move ball up if higher than paddle
                transform.Translate(Vector3.up*speed*Time.deltaTime);
            }
        }

        // Set bounds of AI
        if(transform.position.y > bound){
            transform.position = new Vector3(transform.position.x, bound, 0);
        } else if(transform.position.y < -bound){
            transform.position = new Vector3(transform.position.x, -bound, 0);
        }
    }
}
