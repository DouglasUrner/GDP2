using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
//speed of the ball
    public float speed = 3.5F;

    // The initial direction of the ball
    private Vector2 spawnDir;

    Rigidbody2D rb;
    
    void Start () {
        // Get the ball's Rigidbody2D component.
        rb = this.gameObject.GetComponent<Rigidbody2D>();

        //generating random number based on possible initial directions
        int rand = Random.Range(1,4);

        //setting initial direction
        if (rand == 1) {
            spawnDir = new Vector2(1,1);
        } else if (rand == 2) {
            spawnDir = new Vector2(1,-1);
        } else if (rand == 3) {
            spawnDir = new Vector2(-1,-1);
        } else if (rand == 4) {
            spawnDir = new Vector2(-1,1);
        }

        //moving ball in initial direction and adding speed
        rb.velocity = (spawnDir * speed);
    }
    
    void OnCollisionEnter2D(Collision2D col) {

        //tag check
        if (col.gameObject.tag == "Opponent") {
            //calculate angle
            float y = launchAngle(transform.position,
                col.transform.position,
                col.collider.bounds.size.y);

            //set angle and speed
            Vector2 d = new Vector2(1, y).normalized;
            rig2D.velocity = d * speed * 1.5F;
        }

        if (col.gameObject.tag == "Player") {
            //calculate angle
            float y = launchAngle(transform.position,
                col.transform.position,
                col.collider.bounds.size.y);

            //set angle and speed
            Vector2 d = new Vector2(-1, y).normalized;
            rig2D.velocity = d * speed * 1.5F;
        }
    }

    //calculates the angle the ball hits the paddle at
    float launchAngle(Vector2 ball, Vector2 paddle,
        float paddleHeight) {
        return (ball.y - paddle.y) / paddleHeight;
    }
}
