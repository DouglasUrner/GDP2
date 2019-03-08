using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundController : MonoBehaviour
{
    // Opponent transform
    public Transform opponent;

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Ball"){

            //Destroys other object
            Destroy(other.gameObject);

            //sets enemy's position back to original
            opponent.position = new Vector3(-6,0,0);

            //pauses game
            Time.timeScale = 0;
        }
    }
}
