using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //speed of player
    public float speed = 10;
    public KeyCode pause = KeyCode.P;
    public string axis = "Vertical";

    //bounds of player
    public float bound = 4.5F;

    // Use this for initialization
    void Start () {
        // Setting Time.timeScale to 0 stops time and pauses the game. Only works
        // in single player. This script could be disabled in single player mode on
        // the opponent paddle by the AI script or if worse comes to worse in AI mode
        // there could be a flag to do an early return.
        Time.timeScale = 0;
        Debug.Log("Pause");
    }

    void Update() {
        // Pause or start/resume when player hits pause.
        if (Input.GetKeyDown(pause)) {
            Time.timeScale = (Time.timeScale == 0) ? 1 : 0;
            Debug.Log(Time.timeScale == 0 ? "Pause" : "Resume");
        }
    }

    // Update is called once per frame
    void FixedUpdate () {

        // Get player input and calculate distance to move.
        float movementY = Input.GetAxis(axis) * speed * Time.deltaTime;
        transform.Translate(0, movementY, 0);

        //set bounds of player
        if (transform.position.y > bound) {
            transform.position = new Vector2(transform.position.x, bound);
        } else if (transform.position.y < -bound) {
            transform.position = new Vector2(transform.position.x, -bound);
        }
    }
}