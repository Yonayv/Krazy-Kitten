using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour

{
    float minutes = 1;
    float seconds = 0;
    public GameObject gameOverUI;
    public GameManagerScript gameManager;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    [SerializeField] TextMeshProUGUI TimerText;
   

    // Update is called once per frame
    void Update()
    {
        if (minutes > 0 && Mathf.Approximately(seconds, 0))
        {
            minutes--;
            seconds = 59;
            TimerText.text = minutes.ToString() + ":" + seconds.ToString("f0");
            Debug.Log(minutes + " " + seconds);
        }
        else if (seconds > 0)
        {
            seconds -= Time.deltaTime;
            TimerText.text = minutes.ToString() + ":" + seconds.ToString("f0");
            Debug.Log(minutes + " " + seconds);
        }
        else if (Mathf.Approximately(minutes, 0) && seconds <= 0)
        {
            gameManager.gameOver();
        }


    }

    public void gameOver()
    {
        Time.timeScale = 0f;
        gameOverUI.SetActive(true);
        

    }
}
