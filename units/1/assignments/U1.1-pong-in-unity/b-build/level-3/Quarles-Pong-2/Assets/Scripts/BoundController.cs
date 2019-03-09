using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundController : MonoBehaviour
{
    // Opponent transform
    public Transform opponent;

    public int opponentScore;
    public int playerScore;

    void Start(){
        opponentScore = 0;
        playerScore = 0;
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Ball"){
            if(other.gameObject.GetComponent<Rigidbody2D>().velocity.x > 0){
                opponentScore++;
            } else {
                playerScore++;
            }

            // Destroy other object (ball)
            Destroy(other.gameObject);

            // Set enemy's position back to original
            opponent.position = new Vector3(-6,0,0);
            // Pause game
            Time.timeScale = 0;
        }
    }
}
