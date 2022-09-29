using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class attack : MonoBehaviour
{
    // Start is called before the first frame update
 void dealDamage1(float currenthp1, float damageAmount1, float accuracy1)
   {

        float ran1 = Random.Range(0,100);
        if(ran1 <= accuracy1){
            GameManager.P2healthAmount = currenthp1 -= damageAmount1;
               
        }
        else
        {
            Debug.Log("Missed");
        }

   }     
       
   

   void dealDamage2(float currenthp2, float damageAmount2, float accuracy2)
   {

        float ran2 = Random.Range(0,101);
        if(ran2 <= accuracy2)
        {
             GameManager.P1healthAmount = currenthp2 -= damageAmount2;
               
        }

       else
        {
            Debug.Log("Missed");
        }
   }

 public void P1LowPunch()
    {    
        dealDamage1( GameManager.P2healthAmount,3,75);
        SceneManager. LoadScene(6);
        
         
    }

public void P1HighPunch()
    {       
        dealDamage1( GameManager.P2healthAmount,8,55);
        SceneManager. LoadScene(7);
         
    }

public void P1LowKick()
    {       
        dealDamage1( GameManager.P2healthAmount,6,65);
        SceneManager. LoadScene(8);
         
    }

public void P1HighKick()
    {       
        dealDamage1( GameManager.P2healthAmount,12,45);
        SceneManager. LoadScene(9);
    }

public void P1Special()
    {       
        dealDamage1( GameManager.P2healthAmount,25,100);
        SceneManager. LoadScene(10);
    }

public void P2LowPunch()
    {       
        dealDamage2( GameManager.P1healthAmount,3,75);
        SceneManager. LoadScene(11);
    }

public void P2HighPunch()
    {       
        dealDamage2( GameManager.P1healthAmount,8,55);
        SceneManager. LoadScene(12);
    }

public void P2LowKick()
    {       
        dealDamage2( GameManager.P1healthAmount,6,65);
        SceneManager. LoadScene(13);
    }

public void P2HighKick()
    {       
        dealDamage2( GameManager.P1healthAmount,12,45);
        SceneManager. LoadScene(14);
    }

public void P2Special()
    {       
        dealDamage2( GameManager.P1healthAmount,25,100);
        SceneManager. LoadScene(15);
    }
}
