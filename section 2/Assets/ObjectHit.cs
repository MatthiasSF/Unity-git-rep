using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
Denna klassen registrerar när ett objekt kolliderar med ett annat. OnCollisionEnter är en förskriven metod som registrerar kollision
*/
public class ObjectHit : MonoBehaviour

{
    private void OnCollisionEnter(Collision other) 
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }
}
