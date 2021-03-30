using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public int rotateSpeed = 100;


    // Update is called once per frame
    void Update()
    {   // geting input of mosue x and if it is less then 0 
        if(Input.GetAxis("Mouse X") < 0 )
        {   // do this //
            transform.Rotate(0, -rotateSpeed * Time.deltaTime, 0);
        }
        if(Input.GetAxis("Mouse X") > 0)
        {
            transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
        }
    }
}
