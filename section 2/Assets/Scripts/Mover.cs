using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    /*[SerializeField] används för att manipulera rörelse på x,y,z axeln utan att gå till koden
    [SerializeField] float y = 0.0f;*/

    [SerializeField] float moveSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        movePlayer();
    }
     
      /* Update is called once per frame
     Input.GetAxis används för att tolka värden från input.
     Time.deltaTime gör värdena "framerate independent"
    */
    void movePlayer()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * Time.deltaTime;
        
        x = x * moveSpeed;
        z = z * moveSpeed;

        transform.Translate(x,0,z);

    }
}
