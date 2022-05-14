using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    Rigidbody rBody;
    [SerializeField] float mainThrust = 1000f;
    [SerializeField] float rotateSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust();
        ProcessRotation();
    }
    
    void    ProcessThrust()
    {
        if (Input.GetKey("space")){
            rBody.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
        }     
    }
    
    void ProcessRotation()
    {
        if (Input.GetKey("left") || Input.GetKey ("a")){  
            transform.Rotate(ApplyRotation(true));
        }
        else if (Input.GetKey("right") || Input.GetKey ("d")){
            transform.Rotate(ApplyRotation(false));
        }
        rBody.freezeRotation = false;
    }
    Vector3 ApplyRotation (bool rotationThisFrame)
    {
        rBody.freezeRotation = true;
        Vector3 rotation;
        if (rotationThisFrame == true){
            rotation = Vector3.forward * rotateSpeed * Time.deltaTime;
        }
        else{
            rotation = Vector3.forward * rotateSpeed * Time.deltaTime * -1;
        }
         return rotation;
    }
}
