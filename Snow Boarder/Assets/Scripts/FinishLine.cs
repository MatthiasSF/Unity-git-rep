using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    public  SurfaceEffector2D groundShape;
    [SerializeField] ParticleSystem finishEffect;

    private void Start() {
        
    }
   private void OnTriggerEnter2D(Collider2D other) {
       groundShape = FindObjectOfType<SurfaceEffector2D>();
       if(other.tag == "Player"){
           groundShape.speed = 0;
           finishEffect.Play();
           Invoke ("LoadLevel",1.5f);
       }
   }
   private void LoadLevel(){
     SceneManager.LoadScene("SampleScene");
 }
}
