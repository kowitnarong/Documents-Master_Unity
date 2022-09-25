using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameDev3.Project
{
    public class TimerOrder1 : MonoBehaviour
    {
        public TimeDocumentSet1 timeDocumentSet1;
        public CardScript1 cardScript1;
        public float TimeLeft;
        public int DocOrder;
        private float _TimeLeft;
        public bool TimerOn = false;
        public bool TimeStart = false;

        // Check time up
        static public bool GameIsTimeOut = false;

        public Text TimerTxt;

        void Start()
        {
            getValue(DocOrder);
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
                        GameIsTimeOut = true;
                    }
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                }
                if (cardScript1.Card1Finish == true && _TimeLeft == timeDocumentSet1.Timer1 && DocOrder == 1)
                {
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                }
                else if (cardScript1.Card2Finish == true && _TimeLeft == timeDocumentSet1.Timer2 && DocOrder == 2)
                {
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                }
                else if (cardScript1.Card3Finish == true && _TimeLeft == timeDocumentSet1.Timer3 && DocOrder == 3)
                {
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                }
                else if (cardScript1.Card4Finish == true && _TimeLeft == timeDocumentSet1.Timer4 && DocOrder == 4)
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

        void getValue(int order)
        {
            if (order == 1)
            {
                TimeLeft = timeDocumentSet1.Timer1;
                _TimeLeft = TimeLeft;
            }
            else if (order == 2)
            {
                TimeLeft = timeDocumentSet1.Timer2;
                _TimeLeft = TimeLeft;
            }
            else if (order == 3)
            {
                TimeLeft = timeDocumentSet1.Timer3;
                _TimeLeft = TimeLeft;
            }
            else if (order == 4)
            {
                TimeLeft = timeDocumentSet1.Timer4;
                _TimeLeft = TimeLeft;
            }
        }
    }
}