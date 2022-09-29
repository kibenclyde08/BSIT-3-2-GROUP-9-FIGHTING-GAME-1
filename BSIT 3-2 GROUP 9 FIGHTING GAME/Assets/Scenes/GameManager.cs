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
    public static Slider p1hb;
    public static Slider p2hb;



    void Start()
    {
        P1healthAmount = P1maxhealthAmount;
        P2healthAmount = P2maxhealthAmount;
        p1hb.value = P1healthAmount;
        p2hb.value = P2healthAmount; 
       
    }

   
    void Update()
    {
    

    }



}
