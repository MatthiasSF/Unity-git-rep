using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float horizontalThrow;
    float verticalThrow;
    float newXPos;
    float xOffset = 0.5f;
   
    // Update is called once per frame
    void Update()
    {
        horizontalThrow = Input.GetAxis("Horizontal");
        verticalThrow = Input.GetAxis("Vertical");
        newXPos = transform.localPosition.x + xOffset;

        transform.localPosition = new Vector3(newXPos,transform.localPosition.y, transform.localPosition.z);
    }
}
