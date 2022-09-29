using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class playernamer : MonoBehaviour
{
    
    public GameObject p1stmenuhp;
    public GameObject p2stmenuhp;
    public GameObject p1stmenuhb;
    public GameObject p2stmenuhb;
    public string saveName1;
    public string saveName2; 
    public Text inputText1;
    public Text loadedName1;
    public Text inputText2;
    public Text loadedName2;
    

    void Update()
    {
        GameManager.nameOfPlayers1 = PlayerPrefs.GetString("name1", "none"); 
        loadedName1.text = GameManager.nameOfPlayers1; 

        GameManager.nameOfPlayers2 = PlayerPrefs.GetString("name2", "none"); 
        loadedName2.text =GameManager.nameOfPlayers2;  

        p1stmenuhp.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.P1healthAmount.ToString() + "%";
        p2stmenuhp.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.P2healthAmount.ToString() + "%";
        p1stmenuhb.gameObject.GetComponent<Slider>().value = GameManager.P1healthAmount;
        p2stmenuhb.gameObject.GetComponent<Slider>().value = GameManager.P2healthAmount;
    }


     public void SetName1()
    {
            saveName1 = inputText1.text;
            PlayerPrefs.SetString("name1", saveName1);

    }

    public void SetName2()
    {
            saveName2 = inputText2.text;
            PlayerPrefs.SetString("name2", saveName2);

    }

     public void setstartinghpTo50()
    {
        SetPlayerHP(50);
    }

    public void setstartinghpTo100()
    {
        SetPlayerHP(100);
    }

    public void setstartingTo150()
    {
        SetPlayerHP(150);
    }


     private void SetPlayerHP(int startinghp)
     {
        GameManager.P1healthAmount = startinghp;
        GameManager.P2healthAmount = startinghp;
     }

}
