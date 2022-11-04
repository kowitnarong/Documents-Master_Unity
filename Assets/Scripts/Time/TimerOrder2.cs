using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameDev3.Project
{
    public class TimerOrder2 : MonoBehaviour
    {
        public TimeDocumentSet timeDocumentSet;
        [SerializeField] private float TimeLeft;
        public int DocOrder;
        private float _TimeLeft;
        public bool TimerOn = false;
        public bool TimeStart = false;

        // Check time up
        static public bool GameIsTimeOut = false;

        public Text TimerTxt;

        private bool playSoundClock = false;
        private bool BlinkEffect = false;

        [HideInInspector] public bool order1 = false;
        [HideInInspector] public bool order2 = false;
        [HideInInspector] public bool order3 = false;

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
                if (order1 == true && _TimeLeft == timeDocumentSet.Timer1 && DocOrder == 1)
                {
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                    OffBlinkEffect();
                    order1 = false;
                }
                if (order2 == true && _TimeLeft == timeDocumentSet.Timer2 && DocOrder == 2)
                {
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                    OffBlinkEffect();
                    order2 = false;
                }
                if (order3 == true && _TimeLeft == timeDocumentSet.Timer3 && DocOrder == 3)
                {
                    TimeLeft = 0;
                    TimerOn = false;
                    TimeLeft = _TimeLeft;
                    OffBlinkEffect();
                    order3 = false;
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