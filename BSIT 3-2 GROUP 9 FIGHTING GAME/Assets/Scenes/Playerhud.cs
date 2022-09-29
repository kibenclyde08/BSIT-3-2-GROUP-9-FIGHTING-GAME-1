using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Playerhud : MonoBehaviour
{

public GameObject poneingamename;
public GameObject ptwoingamename;    
public GameObject poneingamehealth;   
public GameObject ptwoingamehealth; 
public GameObject p1stingamehb;
public GameObject p2stingamehb;    
    
    void Start()
    {
      poneingamename.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.nameOfPlayers1 + "";  
      ptwoingamename.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.nameOfPlayers2 + "";  
    }

    // Update is called once per frame
    void Update()
    {
      poneingamehealth.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.P1healthAmount.ToString() + "%";
      ptwoingamehealth.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.P2healthAmount.ToString() + "%";
      p1stingamehb.gameObject.GetComponent<Slider>().value = GameManager.P1healthAmount;
      p2stingamehb.gameObject.GetComponent<Slider>().value = GameManager.P2healthAmount;
    }


}
