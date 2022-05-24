using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] SurfaceEffector2D groundShape;
    [SerializeField] ParticleSystem crashEffect;
    bool isCrashed = false;
 public void OnTriggerEnter2D(Collider2D other) {
    
     if(other.tag == "Evil" && !isCrashed){
         FindObjectOfType<PlayerController>().DisableControls();
         crashEffect.Play();
         GetComponent<AudioSource>().Play();
         groundShape.speed = 0f;
         Invoke ("LoadLevel",1.5f);
         isCrashed = true;
     }
 }
 private void LoadLevel(){
     SceneManager.LoadScene("SampleScene");
 }
}
