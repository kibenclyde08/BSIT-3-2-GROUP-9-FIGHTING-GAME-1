using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    
 
    public static  float P1healthAmount;
    public static float P2healthAmount;
    public static float P1maxhealthAmount;
    public static float P2maxhealthAmount;
    public static string nameOfPlayers1 = "Player1";
    public static string nameOfPlayers2 = "Player2";
    



    void Start()
    {
        P1healthAmount = P1maxhealthAmount;
        P2healthAmount = P2maxhealthAmount;       
    }

   
    void Update()
    {
    

    }



}
