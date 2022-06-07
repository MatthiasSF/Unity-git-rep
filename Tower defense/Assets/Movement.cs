using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Början på movement. Av någon anledning gör inte creepSpeed något utan axisMovement är den som styr farten. 
    //Härnäst skall det implementeras så creepet tar den snabbaste vägen till målet och undviker hinder
    Rigidbody creepBody;
    public float creepSpeed = 10f;
    Vector3 axisMovement = new Vector3(0,0,100);
    bool arrived = false;
    // Start is called before the first frame update
    void Start()
    {
        creepBody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        CreepMover(arrived);
    }
    private void CreepMover(bool arrived){
        if (!arrived){
        creepBody.MovePosition(transform.position + axisMovement * Time.deltaTime * creepSpeed);
        }
       if (arrived){
           Destroy(gameObject);
       }
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Goal"){
            arrived = true;
        }
    }
}
