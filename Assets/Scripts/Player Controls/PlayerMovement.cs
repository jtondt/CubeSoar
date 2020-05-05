using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Forward movement, and sideways movement forces
    public float forwardForce = 2000f;
    //public float sidewaysForce = 600f;

    // Adding gun control to player 
    //public GunController rightGun;
    //public GunController leftGun;

    //Coin "point"
    public int points = 0;

    void Update()
    {
        // Ablility to shoot bullets by pressing space, using a reference from the gun controller script.
        //if (Input.GetKeyDown("w"))
        //{
          //  rightGun.isFiring = true;
          //  leftGun.isFiring = true;
        //}
        //else if (Input.GetKeyUp("w"))
        //{
          //  rightGun.isFiring = false;
          //  leftGun.isFiring = false;
        //}
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //if ( Input.GetKey("d") )
        //{
          //rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}
        //if ( Input.GetKey("a") )
        //{
          //rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}
        if (rb.position.y < -1f)
        {
          FindObjectOfType<GameManager>().GameOver();
        }
    }

    // Adding coin counter to screen
    //private void OnGUI()
    //{
      //  GUI.Label(new Rect(10, 10, 200, 100), "Coins : " + points);
    //}
}
