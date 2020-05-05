using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchMovement : MonoBehaviour
{
    private bool moveLeft;
    private bool moveRight;

    public float sidewaysForce_1 = 600f;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveLeft && !moveRight)
            player.GetComponent<Rigidbody>().AddForce(Vector3.left * sidewaysForce_1);

        if (moveRight && !moveLeft)
            player.GetComponent<Rigidbody>().AddForce(Vector2.right * sidewaysForce_1);
    }

    public void MoveMeLeft()
    {
        moveLeft = true;
    }

    public void StopMeLeft()
    {
        moveLeft = false;
    }

    public void MoveMeRight()
    {
        moveRight = true;
    }

    public void StopMeRight()
    {
        moveRight = false;
    }
}
