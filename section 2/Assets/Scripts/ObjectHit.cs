using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Denna klassen registrerar när ett objekt kolliderar med ett annat. OnCollisionEnter är en förskriven metod som registrerar kollision
Började med att spelaren skulle hoppa tillbaka till ursprungsposition när den träffar ett objekt. Detta blev inte bra där alla rörliga hinder
inte var på sina ursprungliga positioner.
Application.LoadLevel("Scen namn"); startar dock om banan och gav resultatet jag var ute efter
*/
public class ObjectHit : MonoBehaviour
{
   /* Vector3 originalPos;
    GameObject player;
    void Start () {
        /*player = GameObject.FindGameObjectWithTag("Player");
        originalPos = player.transform.position;
        } */
    
     void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag =="Player"){
            Application.LoadLevel("SampleScene");
        //player.transform.position = originalPos;
       /* GetComponent<MeshRenderer>().material.color = Color.red;
        gameObject.tag = "Hit";*/
        }
    }
}
