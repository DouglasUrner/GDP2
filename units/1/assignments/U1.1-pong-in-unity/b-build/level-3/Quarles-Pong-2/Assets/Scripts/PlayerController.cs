using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //speed of player
    public float speed = 10;
    public KeyCode pause = KeyCode.P;

    //bounds of player
    public float bound = 4.5F;

    // Start is called before the first frame update
    void Start () {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update(){

    }

    void FixedUpdate () {

        //get player input and set speed
        float movementSpeedY = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(0, movementSpeedY, 0);

        //set bounds of player
        if(transform.position.y > bound){
            transform.position = new Vector2(transform.position.x, bound);
        } else if(transform.position.y < -bound){
            transform.position = new Vector2(transform.position.x, -bound);
        }
    }
}
