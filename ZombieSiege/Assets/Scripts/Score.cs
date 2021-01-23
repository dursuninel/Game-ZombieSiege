using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text txt;
    public Text hightScore;
    int totalPuan;

    // Player Deadth
    public GameObject can1;
    public GameObject can2;
    public GameObject can3;

    public int isDeadth;

    private GameObject gameOver;
    private void Start()
    {
        totalPuan = 0;
        isDeadth = 0;
    }
    public void killScore()
    {
        totalPuan += 100;
        txt.color = Color.green;
        txt.text = totalPuan.ToString();
        
    }

    public void onCharacterHealth()
    {
        isDeadth++;
        if (isDeadth == 1)
        {
            can3.SetActive(false);
        }
        else if (isDeadth == 2)
        {
            can2.SetActive(false);
        }
        else if (isDeadth == 3)
        {
            can1.SetActive(false);
            if (totalPuan > PlayerPrefs.GetInt("YüksekPuan"))
            {
                PlayerPrefs.SetInt("YüksekPuan", totalPuan);
                PlayerPrefs.Save();
                hightScore.color = Color.green;
                hightScore.text = "Yeni Yüksek Skor : " + PlayerPrefs.GetInt("YüksekPuan");
            }
            else
            {
                hightScore.color = Color.white;
                hightScore.text = "Yüksek Skor : " + PlayerPrefs.GetInt("YüksekPuan");
            }
            GetComponent<GameOver>().gameOver();
        }
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("YüksekPuan", 0);
        hightScore.color = Color.white;
        hightScore.text = "Yüksek Skor : " + PlayerPrefs.GetInt("YüksekPuan");
    }

    
}
