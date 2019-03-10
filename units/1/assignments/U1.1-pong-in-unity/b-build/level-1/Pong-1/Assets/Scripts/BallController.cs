using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
  public float ballSpeed = 10;

  private Rigidbody2D rb;

  // Use this for initialization
  void Start() {
    rb = GetComponent<Rigidbody2D>();
    rb.velocity = LaunchBall();
  }

  /*
   * Randomly select the initial speed and direction for the ball.
   */
  Vector2 LaunchBall() {
    Vector2 vel;
    int quad = Random.Range(1, 5);
    float dir = Random.Range(0.0f, 1.0f);

    // Direction
    if (quad == 1) {
      vel = new Vector2(1, 1);
    } else if (quad == 2) {
      vel = new Vector2(-1, 1);
    } else if (quad == 3) {
      vel = new Vector2(-1, -1);
    } else if (quad == 4) {
      vel = new Vector2(1, -1);
    }

    // Angle
    vel.x = vel.x * ballSpeed * dir;
    vel.y = vel.y * ballSpeed * (1.0f - dir);

    return vel;
  }
}