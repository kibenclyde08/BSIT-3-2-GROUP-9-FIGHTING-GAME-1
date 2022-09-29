using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movesceneintro2 : MonoBehaviour
{
    public float timer4 = 5.100f;

    // Update is called once per frame
    void Update()
    {
      timer4 -= Time.deltaTime;
      if (timer4 <=0)
      {
         SceneManager. LoadScene(2);
      }  
    }
}