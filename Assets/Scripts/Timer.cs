using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public PlayerManager playerManagerScript;

    [SerializeField] TextMeshProUGUI timerText;
    public float startTime;
    public float timerTime;

    public static bool timerFinished;
    public bool timerPaused;

    private static float remainingMinutes;
    private static float remainingSeconds;

    public float t;

    private void Awake()
    {
        timerPaused = false;
        timerFinished = false;
       
    }

    void Start()
    {
        startTime = Time.time + timerTime; //Time in seconds to count down from.
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timerFinished)      //Game over condition when timer runs out.
            return;

        t = Time.time - startTime; //+ Toolbox.Instance.playerManagerScript.time; //Time variable.

        string minutes = ((int)t / 60).ToString();  //Minutes string.
        string seconds = (-t % 60).ToString(format: "f1"); //Seconds string to one decimal place.

        remainingMinutes = t + startTime + Time.time / 60;
        remainingSeconds = t + startTime + Time.time;

        timerText.text = minutes + ":" + seconds; //Text object output.

        if (t >= 0)                 //Timer stop and Game Over condition.
        {
            TimerStop();
            playerManagerScript.GameOver();
        }
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    TimerPause();
        //}
      //  Toolbox.Instance.playerManagerScript.time = t;

    }

    public void TimerStop()
    {
        timerText.color = Color.magenta;
        timerFinished = true;

    }
    public void TimerPause()
    {
        timerText.color = Color.cyan;
        timerPaused = true;
        
    }


}
