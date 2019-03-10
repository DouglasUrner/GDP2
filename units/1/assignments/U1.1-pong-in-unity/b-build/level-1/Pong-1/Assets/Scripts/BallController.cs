using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
  public float ballSpeed = 10;

  /*
   * Start() is called once, just before the first frame in which the object
   * becomes active. It is a good place to do initialization. Start() in the
   * equivalent of the code in Game Lab that is outside of the draw() function.
   */
  void Start() {
    GetComponent<Rigidbody2D>().velocity = ServeBall();
  }

  /*
   * Randomly set the X and Y components of the ball's velocity.
   */
  Vector2 ServeBall() {
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
    } else /* quad == 4 */ {
      vel = new Vector2(1, -1);
    }

    // Angle
    vel.x = vel.x * ballSpeed * dir;
    vel.y = vel.y * ballSpeed * (1.0f - dir);

    return vel;
  }
}