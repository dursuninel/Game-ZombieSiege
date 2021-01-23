using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameExit;
   public void gameOver()
    {
        gameExit.SetActive(true);
        Time.timeScale = 0;
   }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    public void menuLoad()
    {
        SceneManager.LoadScene("Start_Menu");
    }
}
