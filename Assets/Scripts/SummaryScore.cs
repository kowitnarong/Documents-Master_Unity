using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameDev3.Project
{
    public class SummaryScore : MonoBehaviour
    {
        public Text textElementScore;
        public Text textElementStar;
        private string textScore;
        private string textStar;
        private int _Score;

        public SummaryScoreScriptable Level1;
        public SummaryScoreScriptable Level2;
        public SummaryScoreScriptable Level3;

        public GameObject restartButton;
        public GameObject NextlvlButton;

        void Start()
        {
            _Score = Score.ScoreGame;
        }
        void Update()
        {
            textScore = "Score : " + _Score.ToString(); ;
            textElementScore.text = textScore;
            CalculateStar();
            SetButton();
        }

        void SetButton()
        {
            if (textStar == "0 Star")
            {
                restartButton.SetActive(true);
                NextlvlButton.SetActive(false);
            }
            else
            {
                restartButton.SetActive(false);
                NextlvlButton.SetActive(true);
            }
        }

        void CalculateStar()
        {
            if (DifficultSelect.LevelSelect == "Easy")
            {
                SetStarEasy();
            }
            else if (DifficultSelect.LevelSelect == "Normal")
            {
                SetStarNormal();
            }
            else if (DifficultSelect.LevelSelect == "Hard")
            {
                SetStarHard();
            }
        }

        void SetStarEasy()
        {
            if (Score._Level == "Level1")
            {
                if (_Score >= Level1.Score3StarEasy)
                {
                    textStar = "3 Star";
                }
                else if (_Score >= Level1.Score2StarEasy)
                {
                    textStar = "2 Star";
                }
                else if (_Score >= Level1.Score1StarEasy)
                {
                    textStar = "1 Star";
                }
                else if (_Score < Level1.Score1StarEasy)
                {
                    textStar = "0 Star";
                }
                textElementStar.text = textStar;
            }
            else if (Score._Level == "Level2")
            {
                if (_Score >= Level2.Score3StarEasy)
                {
                    textStar = "3 Star";
                }
                else if (_Score >= Level2.Score2StarEasy)
                {
                    textStar = "2 Star";
                }
                else if (_Score >= Level2.Score1StarEasy)
                {
                    textStar = "1 Star";
                }
                else if (_Score < Level2.Score1StarEasy)
                {
                    textStar = "0 Star";
                }
                textElementStar.text = textStar;
            }
            else if (Score._Level == "Level3")
            {
                if (_Score >= Level3.Score3StarEasy)
                {
                    textStar = "3 Star";
                }
                else if (_Score >= Level3.Score2StarEasy)
                {
                    textStar = "2 Star";
                }
                else if (_Score >= Level3.Score1StarEasy)
                {
                    textStar = "1 Star";
                }
                else if (_Score < Level3.Score1StarEasy)
                {
                    textStar = "0 Star";
                }
                textElementStar.text = textStar;
            }
        }

        void SetStarNormal()
        {
            if (Score._Level == "Level1")
            {
                if (_Score >= Level1.Score3StarNormal)
                {
                    textStar = "3 Star";
                }
                else if (_Score >= Level1.Score2StarNormal)
                {
                    textStar = "2 Star";
                }
                else if (_Score >= Level1.Score1StarNormal)
                {
                    textStar = "1 Star";
                }
                else if (_Score < Level1.Score1StarNormal)
                {
                    textStar = "0 Star";
                }
                textElementStar.text = textStar;
            }
            else if (Score._Level == "Level2")
            {
                if (_Score >= Level2.Score3StarNormal)
                {
                    textStar = "3 Star";
                }
                else if (_Score >= Level2.Score2StarNormal)
                {
                    textStar = "2 Star";
                }
                else if (_Score >= Level2.Score1StarNormal)
                {
                    textStar = "1 Star";
                }
                else if (_Score < Level2.Score1StarNormal)
                {
                    textStar = "0 Star";
                }
                textElementStar.text = textStar;
            }
            else if (Score._Level == "Level3")
            {
                if (_Score >= Level3.Score3StarNormal)
                {
                    textStar = "3 Star";
                }
                else if (_Score >= Level3.Score2StarNormal)
                {
                    textStar = "2 Star";
                }
                else if (_Score >= Level3.Score1StarNormal)
                {
                    textStar = "1 Star";
                }
                else if (_Score < Level3.Score1StarNormal)
                {
                    textStar = "0 Star";
                }
                textElementStar.text = textStar;
            }
        }

        void SetStarHard()
        {
            if (Score._Level == "Level1")
            {
                if (_Score >= Level1.Score3StarHard)
                {
                    textStar = "3 Star";
                }
                else if (_Score >= Level1.Score2StarHard)
                {
                    textStar = "2 Star";
                }
                else if (_Score >= Level1.Score1StarHard)
                {
                    textStar = "1 Star";
                }
                else if (_Score < Level1.Score1StarHard)
                {
                    textStar = "0 Star";
                }
                textElementStar.text = textStar;
            }
            else if (Score._Level == "Level2")
            {
                if (_Score >= Level2.Score3StarHard)
                {
                    textStar = "3 Star";
                }
                else if (_Score >= Level2.Score2StarHard)
                {
                    textStar = "2 Star";
                }
                else if (_Score >= Level2.Score1StarHard)
                {
                    textStar = "1 Star";
                }
                else if (_Score < Level2.Score1StarHard)
                {
                    textStar = "0 Star";
                }
                textElementStar.text = textStar;
            }
            else if (Score._Level == "Level3")
            {
                if (_Score >= Level3.Score3StarHard)
                {
                    textStar = "3 Star";
                }
                else if (_Score >= Level3.Score2StarHard)
                {
                    textStar = "2 Star";
                }
                else if (_Score >= Level3.Score1StarHard)
                {
                    textStar = "1 Star";
                }
                else if (_Score < Level3.Score1StarHard)
                {
                    textStar = "0 Star";
                }
                textElementStar.text = textStar;
            }
        }
    }
}