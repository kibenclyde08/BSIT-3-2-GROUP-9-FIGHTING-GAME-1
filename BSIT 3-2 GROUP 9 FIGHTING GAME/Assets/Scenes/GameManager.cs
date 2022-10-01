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
    public static float p1mana;
    public static float p2mana;
    public static float p1maxmana = 100f;
    public static float p2maxmana = 100f;
    



    void Start()
    {
        P1healthAmount = P1maxhealthAmount;
        P2healthAmount = P2maxhealthAmount;
        p1mana = p1maxmana = 100f; 
        p2mana = p2maxmana = 100f;      
    }

   
    void Update()
    {
    

    }



}
