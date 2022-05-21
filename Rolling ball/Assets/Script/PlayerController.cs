using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Touch touch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }
    private void MovePlayer(){
        if (Input.touchCount > 0){
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)      {
                transform.position = new Vector3(transform.position.x - touch.deltaPosition.x * Time.deltaTime, transform.position.y, transform.position.z);

            }
        }
    }
}
