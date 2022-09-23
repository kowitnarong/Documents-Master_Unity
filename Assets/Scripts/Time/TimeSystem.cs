using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameDev3.Project
{
    public class TimeSystem : MonoBehaviour
    {
        public bool Working = false;
        public GameObject TimeBG;
        public GameObject TimeObject;

        // Update is called once per frame
        void Update()
        {
            if (Working == true)
            {
                TimeBG.SetActive(true);
            }
            else
            {
                TimeObject.GetComponent<Image>().fillAmount = 0;
                TimeObject.GetComponent<TimeCount>().timeLeft = 0;
                TimeBG.SetActive(false);
            }
        }
    }
}