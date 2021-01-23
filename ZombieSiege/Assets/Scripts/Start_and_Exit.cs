using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_and_Exit : MonoBehaviour
{

    public void basla()
    {
        SceneManager.LoadScene("Game");
        Time.timeScale = 1;
    }
    public void cikis()
    {
        Application.Quit();
    }
}
