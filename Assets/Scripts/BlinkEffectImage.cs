using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameDev3.Project
{
    public class BlinkEffectImage : MonoBehaviour
    {
        private Color startColor;
        public Color endColor = Color.white;
        [Range(0f, 100f)]
        public float speed = 0;

        Image imageComp;

        private void Awake()
        {
            imageComp = GetComponent<Image>();
            startColor = imageComp.color;
        }

        private void Update()
        {
            imageComp.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
        }
    }
}