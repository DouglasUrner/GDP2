using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
  public KeyCode moveUp = KeyCode.W;
	public KeyCode moveDown = KeyCode.S;
	public float speed = 10.0f;
	public float boundY = 2.25f;

	private Rigidbody2D rb;

	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody2D>(); 
	}

	// Update is called once per frame
	void Update()
	{
    var vel = rb.velocity;

    if (Input.GetKey(moveUp)) {
        vel.y = speed;
    }
    else if (Input.GetKey(moveDown)) {
        vel.y = -speed;
    }
    else {
        vel.y = 0;
    }
    rb.velocity = vel;
	}
}
