using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingObject : MonoBehaviour
{
    [SerializeField] float fallTimer = 3f;
    MeshRenderer mRenderer;
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        mRenderer = GetComponent<MeshRenderer>();
        body = GetComponent<Rigidbody>();

        mRenderer.enabled = false;
        body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
      
      startFalling(Time.time);
        
    }
    void startFalling (float gameTime){

        if (gameTime >= fallTimer){
            mRenderer.enabled = true;
            body.useGravity = true;
        }
    }
}
