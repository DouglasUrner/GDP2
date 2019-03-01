/*
 * These using statements are included by Unity when it generates the
 * script file. For this game, they are not used. They are commented out
 * so that they will not generate "advice" from Rider.
 *
using System.Collections;
using System.Collections.Generic;
 */

using UnityEngine;

public class Paddle : MonoBehaviour
{
    /*
     * Variables declared as public in the outer scope of a class which
     * derives from MonoBehavior will be visible in the Unity editor and
     * can be set there.
     */
    public string Axis = " --- Select Input axis for this paddle --- ";
    public float Speed = 10;

// Start is called before the first frame update
    private void Start()
    {
    }

// Update is called once per frame
    private void Update()
    {
        var v = Input.GetAxisRaw(Axis);
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * Speed;
    }
}