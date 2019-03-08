using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    // Speed of the opponent paddle.
    public float speed = 1.75F;

    // The ball
    Transform ball;

    // The ball's Rigidbody2D
    Rigidbody2D ballRb;

    //bounds of enemy
    public float bound = 4.5F;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void FixedUpdate () {

        //finding the ball
        ball = GameObject.FindGameObjectWithTag("Ball").transform;

        //setting the ball's rigidbody to a variable
        ballRb = ball.GetComponent<Rigidbody2D>();

        //checking x direction of the ball
        if(ballRb.velocity.x < 0){

            //checking y direction of ball
            if(ball.position.y < this.transform.position.y){
                //move ball down if lower than paddle
                transform.Translate(Vector3.down*speed*Time.deltaTime);
            } else if(ball.position.y > this.transform.position.y){
                //move ball up if higher than paddle
                transform.Translate(Vector3.up*speed*Time.deltaTime);
            }

        }

        //set bounds of opponent
        if(transform.position.y > bound){
            transform.position = new Vector3(transform.position.x, bound, 0);
        } else if(transform.position.y < -bound){
            transform.position = new Vector3(transform.position.x, -bound, 0);
        }
    }
}
