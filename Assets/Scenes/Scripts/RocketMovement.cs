using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        upwardThrust()
        rotate()
    }

    void upwardThrust(){
        if (Input.GetKey(KeyCode.Space))
        {
            debug.info("space is pressed")
        }
    }

    void rotate(){
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            debug.info("going left")
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            debug.info("going right")
        }
    }
}
