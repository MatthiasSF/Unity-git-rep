using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2D;
    [SerializeField] float torqueForce = 1;
    [SerializeField] SurfaceEffector2D groundShape;
    float baseSpeed = 20f;
    float boostSpeed = 30f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb2D.AddTorque(torqueForce);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            rb2D.AddTorque(-torqueForce);
        }
        if (Input.GetKey(KeyCode.UpArrow)){
            groundShape.speed = boostSpeed;
        }
        else{
            groundShape.speed = baseSpeed;
        }
    }
}
