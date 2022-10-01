using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameoverscript : MonoBehaviour
{
  public  GameObject gameoverplayer1name;
  public  GameObject gameoverplayer2name;

void Start()
    {
      gameoverplayer1name.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.nameOfPlayers1 + " Wins";  
      gameoverplayer2name.gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = GameManager.nameOfPlayers2 + " Wins";  
    }

public void Setup()
{
  gameObject.SetActive(true);  
}

public void RestartButton()
{
    SceneManager.LoadScene(3);
}

public void ExitButton()
{
     Application.Quit();
      Debug.Log("Game is exiting");
}

}
