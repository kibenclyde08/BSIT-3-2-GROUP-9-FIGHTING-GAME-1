using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Scenechanges : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScenes()
    {
        SceneManager.LoadScene(4);
    }

     public void gobacktomenu()
    {
        SceneManager.LoadScene(2);
    }
}

