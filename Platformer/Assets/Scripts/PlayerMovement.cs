using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpHeight = 4f;
    [SerializeField] float movespeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            transform.Translate(0,jumpHeight * Time.deltaTime,0);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(movespeed * Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-movespeed * Time.deltaTime,0,0);
        }
        
    }
}
