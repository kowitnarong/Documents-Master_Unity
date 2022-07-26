using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerOrder : MonoBehaviour
{

    public float TimeLeft;
    private float _TimeLeft;
    public bool TimerOn = false;

    public Text TimerTxt;

    void Start()
    {
        _TimeLeft = TimeLeft;
    }

    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else
            {
                Debug.Log("Time UP!");
                TimeLeft = 0;
                TimerOn = false;
                TimeLeft = _TimeLeft;
            }
            if (CardScript.Card1Finish == true && _TimeLeft == 60)
            {
                TimeLeft = 0;
                TimerOn = false;
                TimeLeft = _TimeLeft;
            }
            else if (CardScript.Card2Finish == true && _TimeLeft == 75)
            {
                TimeLeft = 0;
                TimerOn = false;
                TimeLeft = _TimeLeft;
            }
            else if (CardScript.Card3Finish == true && _TimeLeft == 65)
            {
                TimeLeft = 0;
                TimerOn = false;
                TimeLeft = _TimeLeft;
            }
            else if (CardScript.Card4Finish == true && _TimeLeft == 70)
            {
                TimeLeft = 0;
                TimerOn = false;
                TimeLeft = _TimeLeft;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
