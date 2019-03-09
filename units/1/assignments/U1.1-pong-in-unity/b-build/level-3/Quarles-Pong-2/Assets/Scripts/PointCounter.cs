using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCounter : MonoBehaviour
{
    public GameObject rightBound;
    public GameObject leftBound;
    Text text;
    
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        text.text = rightBound.GetComponent<BoundController>().opponentScore + "\t" +
                    leftBound.GetComponent<BoundController>().playerScore;
    }

    // Update is called once per frame
    void Update () {
        text.text = rightBound.GetComponent<BoundController>().opponentScore + "\t" +
                    leftBound.GetComponent<BoundController>().playerScore;
    }
}
