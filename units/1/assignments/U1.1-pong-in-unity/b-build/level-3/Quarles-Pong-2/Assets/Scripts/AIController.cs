using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour {
  public float speed = 1.75F;

  // The ball
  GameObject ball;

  //the ball's rigidbody 2D
  Rigidbody2D ballRb;

  //bounds of enemy
  public float bound = 4.5F;

  // Use this for initialization
  void Start() {
    //Continuously Invokes Move every x seconds (values may differ)
    InvokeRepeating("Move", .02F, .02F);
  }

  // Movement for the paddle
  void Move() {
    // If the ball was destroyed in the last frame it will be null.
    if (ball == null) {
      ball = GameObject.FindGameObjectWithTag("Ball");
    } else {
      // TODO: ask the BallController where the ball is.
      // setting the ball's rigidbody to a variable
      ballRb = ball.GetComponent<Rigidbody2D>();

      // If ball is coming our way (moving to left).
      if (ballRb.velocity.x < 0) {
        // checking y direction of ball
        if (ball.transform.position.y < transform.position.y - 0.5F) {
          // move ball down if lower than paddle
          transform.Translate(Vector3.down * speed * Time.deltaTime);
        } else if (ball.transform.position.y > transform.position.y + 0.5F) {
          // move ball up if higher than paddle
          transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
      }
    }

    // Constrain paddle to stay in bounds.
    if (transform.position.y > bound) {
      transform.position = new Vector3(transform.position.x, bound, 0);
    } else if (transform.position.y < -bound) {
      transform.position = new Vector3(transform.position.x, -bound, 0);
    }
  }
}