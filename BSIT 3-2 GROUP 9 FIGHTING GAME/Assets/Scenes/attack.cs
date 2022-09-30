using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class attack : MonoBehaviour
{
 
void Update()
{
       if(GameManager.P2healthAmount <= 0)
        {
           GameManager.P2healthAmount = 0;
           SceneManager. LoadScene(24);
        }

        if(GameManager.P1healthAmount <= 0)
        {
           GameManager.P1healthAmount = 0;
           SceneManager. LoadScene(25);
        }

}





public void P1lowpunch(){
    int p1lp, accuracyp1 = 75;
    p1lp = Random.Range(0,100);
     if(p1lp <= accuracyp1){
    GameManager.P2healthAmount -= 3f;
    SceneManager. LoadScene(6);
    Debug.Log("Attack Success");
     }
     else{
         SceneManager. LoadScene(16);
        Debug.Log("Attack Missed");
     }

    }

    public void P1highpunch(){
    int p1hp, accuracyp1 = 55;
    p1hp = Random.Range(0,100);
     if(p1hp <= accuracyp1){
    GameManager.P2healthAmount -= 8f;
    SceneManager. LoadScene(7);
    Debug.Log("Attack Success");
     }
     else{
         SceneManager. LoadScene(17);
        Debug.Log("Attack Missed");
     }
    }

    
    public void P1lowkick(){
    int p1lk, accuracyp1 = 65;
    p1lk = Random.Range(0,100);
     if(p1lk <= accuracyp1){
    GameManager.P2healthAmount -= 6f;
    SceneManager. LoadScene(8);
    Debug.Log("Attack Success");
     }
     else{
         SceneManager. LoadScene(18);
        Debug.Log("Attack Missed");
     }
    }

   

public void P1highkick()
{
    int p1hk, accuracyp1 = 45;
    p1hk = Random.Range(0,100);
     if(p1hk <= accuracyp1){
    GameManager.P2healthAmount -= 12f;
    SceneManager. LoadScene(9);
    Debug.Log("Attack Success");
     }
     else{
         SceneManager. LoadScene(19);
        Debug.Log("Attack Missed");
     }
    }

public void P1specialattack()
{                   
        GameManager.P2healthAmount -= 25f;
        SceneManager. LoadScene(10);
        Debug.Log("Attack Success");      
}    


public void P2lowpunch(){
    int p2lp, accuracyp2 = 75;
    p2lp = Random.Range(0,100);
     if(p2lp <= accuracyp2){
    GameManager.P1healthAmount -= 3f;
    SceneManager. LoadScene(11);
    Debug.Log("Attack Success");
     }
     else{
         SceneManager. LoadScene(20);
        Debug.Log("Attack Missed");
     }
    }

    public void P2highpunch(){
    int p2hp, accuracyp2 = 55;
    p2hp = Random.Range(0,100);
     if(p2hp <= accuracyp2){
    GameManager.P1healthAmount -= 8f;
    SceneManager. LoadScene(12);
    Debug.Log("Attack Success");
     }
     else{
         SceneManager. LoadScene(21);
        Debug.Log("Attack Missed");
     }
    }

    
    public void P2lowkick(){
    int p2lk, accuracyp2 = 65;
    p2lk = Random.Range(0,100);
     if(p2lk <= accuracyp2){
    GameManager.P1healthAmount -= 6f;
    SceneManager. LoadScene(13);
    Debug.Log("Attack Success");
     }
     else{
         SceneManager. LoadScene(22);
        Debug.Log("Attack Missed");
     }
    }

   

public void P2highkick()
{
    int p2hk, accuracyp2 = 45;
    p2hk = Random.Range(0,100);
     if(p2hk <= accuracyp2){
    GameManager.P1healthAmount -= 12f;
    SceneManager. LoadScene(14);
    Debug.Log("Attack Success");
     }
     else{
         SceneManager. LoadScene(23);
        Debug.Log("Attack Missed");
     }
    }

public void P2specialattack()
{                   
        GameManager.P1healthAmount -= 25f;
        SceneManager. LoadScene(15);
        Debug.Log("Attack Success"); 
    
}   
 

 
}
