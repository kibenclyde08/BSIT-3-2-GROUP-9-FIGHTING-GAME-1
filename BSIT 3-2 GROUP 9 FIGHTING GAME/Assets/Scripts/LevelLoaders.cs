using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaders : MonoBehaviour
{
    public Animator transition;

    // Update is called once per frame
    void Update()
    {
       
    }

    public void LoadNextLevels()
    {
        StartCoroutine(LoadLevel(5)); 
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(1);
        SceneManager. LoadScene(levelIndex);
    }



}