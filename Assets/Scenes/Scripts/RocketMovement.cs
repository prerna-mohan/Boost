using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMovement : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float upThrust = 1300f;
    [SerializeField] float rotateThrust = 100f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
            rb.AddRelativeForce(Vector3.up * upThrust * Time.deltaTime);
        }
    }

    void ProcessRotate(){
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotateThrust * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * rotateThrust * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision){
        rb.freezeRotation = false;
        if(collision.gameObject.layer == 6){
            Invoke("Respawn",2);
            GetComponent<RocketMovement>().enabled = false;
        }
    }

    void Respawn(){
        
    }
}
