using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private float increaseOfSpeed = 0.1f;
    [SerializeField] private float turnSpeed = 200f;
    private int steerValue;
    
    // Update is called once per frame
    void Update()
    {
        speed += increaseOfSpeed * Time.deltaTime;
        transform.Rotate (0f, steerValue*turnspeed+Time.deltaTime, 0f);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void Steer (int value){
        steerValue = value;
    }
}
