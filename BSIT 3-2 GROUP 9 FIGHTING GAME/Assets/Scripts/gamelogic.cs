using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamelogic : MonoBehaviour
{
    
    public string nameOfPlayers1;
    public string saveName1;
    public string nameOfPlayers2;
    public string saveName2;

    public Text inputText1;
    public Text loadedName1;
    public Text inputText2;
    public Text loadedName2;

    void Start()
    {
        
    }

    
    void Update()
    {
        nameOfPlayers1 = PlayerPrefs.GetString("name1", "none"); 
        loadedName1.text = nameOfPlayers1; 

        nameOfPlayers2 = PlayerPrefs.GetString("name2", "none"); 
        loadedName2.text = nameOfPlayers2; 
   
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

    

}
