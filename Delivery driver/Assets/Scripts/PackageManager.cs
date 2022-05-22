using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PackageManager : MonoBehaviour
{
    int remainingPackages;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        remainingPackages = GameObject.FindGameObjectsWithTag("Package").Length;
        if (remainingPackages == 0){
            SceneManager.LoadScene("SampleScene");
        }
    }
}
