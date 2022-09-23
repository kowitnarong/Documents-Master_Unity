using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

using UnityEngine.SceneManagement;

namespace GameDev3.Project
{
    public class TimeCount : MonoBehaviour
    {
        Image timerBar;
        public float maxTime;
        public float timeLeft;
        void Start()
        {
            timerBar = GetComponent<Image>();
            timeLeft = 0;
        }
        void Update()
        {
            TimeCheck();
        }
        void TimeCheck()
        {
            if (timeLeft < maxTime)
            {
                timeLeft += Time.deltaTime;
                timerBar.fillAmount = timeLeft / maxTime;
            }
        }
    }
}