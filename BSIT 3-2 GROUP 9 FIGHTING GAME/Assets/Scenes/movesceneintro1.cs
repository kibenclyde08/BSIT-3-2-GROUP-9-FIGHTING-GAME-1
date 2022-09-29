using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movesceneintro1 : MonoBehaviour
{
    public float timer3 = 5f;

    // Update is called once per frame
    void Update()
    {
      timer3 -= Time.deltaTime;
      if (timer3 <=0)
      {
         SceneManager. LoadScene(1);
      }  
    }
}
