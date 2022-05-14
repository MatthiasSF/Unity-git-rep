using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    float fallTimer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
      startFalling(Time.time);
        
    }
    void startFalling (float gameTime){
        float fallSpeed = -58 * Time.deltaTime;

        if (gameTime >= fallTimer){
            
            transform.Translate(0,fallSpeed,0);
        }
    }
}
