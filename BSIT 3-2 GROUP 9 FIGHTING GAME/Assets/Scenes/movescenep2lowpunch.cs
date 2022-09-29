using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movescenep2lowpunch : MonoBehaviour
{
    public float timer2 = 5f;

    // Update is called once per frame
    void Update()
    {
      timer2 -= Time.deltaTime;
      if (timer2 <=0)
      {
         SceneManager. LoadScene(4);
      }  
    }
}
