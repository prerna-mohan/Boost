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
        ProcessThrust();
        ProcessRotate();
    }

    void ProcessThrust(){
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("space is pressed");
        }
    }

    void ProcessRotate(){
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("going left");
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("going right");
        }
    }
}
