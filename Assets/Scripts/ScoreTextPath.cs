using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace GameDev3.Project
{
    public class ScoreTextPath : MonoBehaviour
    {
        private TextMeshProUGUI textMesh;
        private float disappearTimer;
        private Color textColor;

        private void Awake()
        {
            textMesh = GetComponent<TextMeshProUGUI>();
            Setup();
        }

        public void Setup()
        {
            textColor = textMesh.color;
            disappearTimer = 0.5f;
        }
        
        private void Update()
        {
            float moveYSpeed = 2f;
            transform.position += new Vector3(0, moveYSpeed * Time.deltaTime);

            disappearTimer -= Time.deltaTime;
            if (disappearTimer < 0)
            {
                float disappearSpeed = 3f;
                Color color = textMesh.color;
                color.a -= disappearSpeed * Time.deltaTime;
                textMesh.color = color;

                if (color.a < 0)
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}