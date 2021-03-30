using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    public GameObject playerObject;
    public bool isRunning;
    public float horizontalMove;
    public float verticalMove;
    public int turnHorizontalSpeed = 150;
    public int forwardVerticalSpeed = 8;

    // Update is called once per frame
    void Update()
    {
        // checking if Horizontal or Vertical button pressed.
        if(Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {            // if  ture set this //
            playerObject.GetComponent<Animation>().Play("Run");
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * turnHorizontalSpeed;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * forwardVerticalSpeed;
            isRunning = true;
                    // then do this //
            transform.Rotate(0, horizontalMove, 0);
            transform.Translate(0, 0, verticalMove);
        }
        else
        {          // do this // 
            playerObject.GetComponent<Animation>().Play("Idle");
            isRunning = false;
        }
    }
}
