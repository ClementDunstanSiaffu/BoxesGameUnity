using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{
    public bool hasGameStopped = false;
    public float delayTimer = 1f;
    public GameObject levelUI;

    //public void Start()
    //{
    //    //levelUI = GameObject.Find("NextLevelPanel");
    //}

    public void endGame()
    {
        if (!hasGameStopped)
        {
            hasGameStopped = true;
            Invoke("restart", delayTimer);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void showLevelPanel()
    {
        levelUI.SetActive(true);
        Invoke("navigateToNextScene", delayTimer);
    }

    public void navigateToNextScene()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 <= 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
      


}
