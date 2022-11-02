using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameDev3.Project
{
    public class TimerOrder1 : MonoBehaviour
    {
        public TimeDocumentSet timeDocumentSet;
        public CardScript1 cardScript1;
        public float TimeLeft;
        public int DocOrder;
        private float _TimeLeft;
        public bool TimerOn = false;
        public bool TimeStart = false;

        // Check time up
        static public bool GameIsTimeOut = false;

        public Text TimerTxt;

        private bool playSoundClock = false;
        private bool BlinkEffect = false;

        void Start()
        {
            GameIsTimeOut = false;
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
                    if (TimeStart && TimeLeft < 10 && playSoundClock == false)
                    {
                        FindObjectOfType<AudioManager>().Play("Clock");
                        playSoundClock = true;
                    }
                    if (TimeLeft < 10 && BlinkEffect == false)
                    {
                        OnBlinkEffect();
                        BlinkEffect = true;
                    }
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
                    OffBlinkEffect();
                }
                if (cardScript1.Card1Finish == true && _TimeLeft == timeDocumentSet.Timer1 && DocOrder == 1)
                {
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                    OffBlinkEffect();
                }
                else if (cardScript1.Card2Finish == true && _TimeLeft == timeDocumentSet.Timer2 && DocOrder == 2)
                {
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                    OffBlinkEffect();
                }
                else if (cardScript1.Card3Finish == true && _TimeLeft == timeDocumentSet.Timer3 && DocOrder == 3)
                {
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                    OffBlinkEffect();
                }
                else if (cardScript1.Card4Finish == true && _TimeLeft == timeDocumentSet.Timer4 && DocOrder == 4)
                {
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                    OffBlinkEffect();
                }
            }
        }

        void OnBlinkEffect()
        {
            var animation = GetComponent<BlinkEffectImage>();
            animation.speed = 4;
        }
        
        void OffBlinkEffect()
        {
            var animation = GetComponent<BlinkEffectImage>();
            animation.speed = 0;
            BlinkEffect = false;
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
                TimeLeft = timeDocumentSet.Timer1;
                _TimeLeft = TimeLeft;
            }
            else if (order == 2)
            {
                TimeLeft = timeDocumentSet.Timer2;
                _TimeLeft = TimeLeft;
            }
            else if (order == 3)
            {
                TimeLeft = timeDocumentSet.Timer3;
                _TimeLeft = TimeLeft;
            }
            else if (order == 4)
            {
                TimeLeft = timeDocumentSet.Timer4;
                _TimeLeft = TimeLeft;
            }
        }
    }
}