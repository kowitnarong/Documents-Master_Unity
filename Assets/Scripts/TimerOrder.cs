using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerOrder : MonoBehaviour
{

    public float TimeLeft;
    public int DocOrder;
    private float _TimeLeft;
    public bool TimerOn = false;
    public bool TimeStart = false;

    public Text TimerTxt;
    static public float Timer1;
    static public float Timer2;
    static public float Timer3;
    static public float Timer4;

    void Start()
    {
        getValue(TimeLeft, DocOrder);
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
                //Debug.Log("Time UP!");
                if (TimeStart)
                {
                    Time.timeScale = 0;
                }
                TimeLeft = 0;
                TimerOn = false;
                TimeLeft = _TimeLeft;
            }
            if (CardScript.Card1Finish == true && _TimeLeft == Timer1)
            {
                TimeLeft = 0;
                TimerOn = false;
                TimeLeft = _TimeLeft;
            }
            else if (CardScript.Card2Finish == true && _TimeLeft == Timer2)
            {
                TimeLeft = 0;
                TimerOn = false;
                TimeLeft = _TimeLeft;
            }
            else if (CardScript.Card3Finish == true && _TimeLeft == Timer3)
            {
                TimeLeft = 0;
                TimerOn = false;
                TimeLeft = _TimeLeft;
            }
            else if (CardScript.Card4Finish == true && _TimeLeft == Timer4)
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

    void getValue(float time, int order)
    {
        if (order == 1)
        {
            Timer1 = time;
            _TimeLeft = Timer1;
        }
        else if (order == 2)
        {
            Timer2 = time;
            _TimeLeft = Timer2;
        }
        else if (order == 3)
        {
            Timer3 = time;
            _TimeLeft = Timer3;
        }
        else if (order == 4)
        {
            Timer4 = time;
            _TimeLeft = Timer4;
        }
    }
}
