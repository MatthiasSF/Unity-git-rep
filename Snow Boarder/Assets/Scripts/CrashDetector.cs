using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] SurfaceEffector2D groundShape;
    [SerializeField] ParticleSystem crashEffect;
 private void OnTriggerEnter2D(Collider2D other) {
     if(other.tag == "Evil"){
         crashEffect.Play();
         groundShape.speed = 0.3f;
         Invoke ("LoadLevel",1.5f);
         
     }
 }
 private void LoadLevel(){
     SceneManager.LoadScene("SampleScene");
 }
}
