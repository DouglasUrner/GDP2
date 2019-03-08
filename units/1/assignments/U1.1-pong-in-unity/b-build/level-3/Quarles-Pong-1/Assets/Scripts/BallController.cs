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
}
