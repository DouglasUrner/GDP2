﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
//speed of the ball
    public float speed = 3.5F;

    Rigidbody2D rb;
    
    void Start () {
        // Get the ball's Rigidbody2D component.
        rb = this.gameObject.GetComponent<Rigidbody2D>();

        Vector2 quad = Vector2.zero;

        // Pick a quadrant to serve into.
        switch ((int) Random.Range(1,5)) {
            case 1: // First quadrant.
                quad = new Vector2(1, 1);
                break;
            case 2: // Second quadrant.
                quad = new Vector2(-1, 1);
                break;
            case 3: // Third quadrant.
                quad = new Vector2(-1, -1);
                break;
            case 4: // Fourth quadrant.
                quad = new Vector2(1, -1);
                break;
        }
        Debug.Log("Serving into quadrant: " + quad);

        //moving ball in initial direction and adding speed
        rb.velocity = (quad * speed);
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
            rb.velocity = d * speed * 1.5F;
        }

        if (col.gameObject.tag == "Player") {
            //calculate angle
            float y = launchAngle(transform.position,
                col.transform.position,
                col.collider.bounds.size.y);

            //set angle and speed
            Vector2 d = new Vector2(-1, y).normalized;
            rb.velocity = d * speed * 1.5F;
        }
    }

    //calculates the angle the ball hits the paddle at
    float launchAngle(Vector2 ball, Vector2 paddle,
        float paddleHeight) {
        return (ball.y - paddle.y) / paddleHeight;
    }
}
