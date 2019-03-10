using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {
  /*
   * Class fields (variables) with a storage class of public are
   * visible in the Inspector in Unity and can be set there. Since
   * the code of the PaddleController script is shared by both paddles,
   * we make the KeyCodes public so that we can set them separately for
   * each paddle.
   *
   * When a script is shared with multiple gameObjects the class methods
   * (Start() and Update() here) are shared, but each gameObject gets its
   * own copy of the public fields.
   */
  public KeyCode moveUp = KeyCode.None;
  public KeyCode moveDown = KeyCode.None;
  public float paddleSpeed = 0.1f;

  // Start is called before the first frame update.
  void Start() {
    // Check that KeyCode values are set.
    if (moveUp == KeyCode.None) {
      Debug.Log("The moveUp KeyCode is not set for " + gameObject.name);
    }
    if (moveDown == KeyCode.None) {
      Debug.Log("The moveDown KeyCode is not set for " + gameObject.name);
    }
  }

  // Update is called once per frame.
  void Update() {
    var pos = transform.position;

    if (Input.GetKey(moveUp)) {
      pos.y = pos.y + paddleSpeed;
    } else if (Input.GetKey(moveDown)) {
      pos.y = pos.y - paddleSpeed;
    }

    transform.position = pos;
  }
}