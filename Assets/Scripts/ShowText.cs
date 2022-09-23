using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameDev3.Project
{
    public class ShowText : MonoBehaviour
    {
        public Text textElementScore;
        private string textScore;
        void Update()
        {
            textScore = "" + Score.ScoreGame.ToString();

            textElementScore.text = textScore;
        }
    }
}
