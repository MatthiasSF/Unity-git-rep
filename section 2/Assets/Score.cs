using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int score = -2;

   private void OnCollisionEnter(Collision other) {
       score ++;
       if (score > 0){
       Debug.Log ("You bumped into the wall " + score);
       }
   }
}
