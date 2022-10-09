using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace GameDev3.Project
{
    public class SummaryScore : MonoBehaviour
    {
        public Animator Star1;
        public Animator Star2;
        public Animator Star3;

        public Text textElementTitle;
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

        private bool setStar1 = false;
        private bool setStar2 = false;
        private bool setStar3 = false;

        void Start()
        {
            if (Score._Level == "Level1")
            {
                textElementTitle.text = "Level 1";
            }
            else if (Score._Level == "Level2")
            {
                textElementTitle.text = "Level 2";
            }
            _Score = Score.ScoreGame;
        }
        void Update()
        {
            textScore = _Score.ToString();
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
                    Set3Star();
                }
                else if (_Score >= Level1.Score2StarEasy)
                {
                    textStar = "2 Star";
                    Set2Star();
                }
                else if (_Score >= Level1.Score1StarEasy)
                {
                    textStar = "1 Star";
                    Set1Star();
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
                    Set3Star();
                }
                else if (_Score >= Level2.Score2StarEasy)
                {
                    textStar = "2 Star";
                    Set2Star();
                }
                else if (_Score >= Level2.Score1StarEasy)
                {
                    textStar = "1 Star";
                    Set1Star();
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
                    Set3Star();
                }
                else if (_Score >= Level3.Score2StarEasy)
                {
                    textStar = "2 Star";
                    Set2Star();
                }
                else if (_Score >= Level3.Score1StarEasy)
                {
                    textStar = "1 Star";
                    Set1Star();
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
                    Set3Star();
                }
                else if (_Score >= Level1.Score2StarNormal)
                {
                    textStar = "2 Star";
                    Set2Star();
                }
                else if (_Score >= Level1.Score1StarNormal)
                {
                    textStar = "1 Star";
                    Set1Star();
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
                    Set3Star();
                }
                else if (_Score >= Level2.Score2StarNormal)
                {
                    textStar = "2 Star";
                    Set2Star();
                }
                else if (_Score >= Level2.Score1StarNormal)
                {
                    textStar = "1 Star";
                    Set1Star();
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
                    Set3Star();
                }
                else if (_Score >= Level3.Score2StarNormal)
                {
                    textStar = "2 Star";
                    Set2Star();
                }
                else if (_Score >= Level3.Score1StarNormal)
                {
                    textStar = "1 Star";
                    Set1Star();
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
                    Set3Star();
                }
                else if (_Score >= Level1.Score2StarHard)
                {
                    textStar = "2 Star";
                    Set2Star();
                }
                else if (_Score >= Level1.Score1StarHard)
                {
                    textStar = "1 Star";
                    Set1Star();
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
                    Set3Star();
                }
                else if (_Score >= Level2.Score2StarHard)
                {
                    textStar = "2 Star";
                    Set2Star();
                }
                else if (_Score >= Level2.Score1StarHard)
                {
                    textStar = "1 Star";
                    Set1Star();
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
                    Set3Star();
                }
                else if (_Score >= Level3.Score2StarHard)
                {
                    textStar = "2 Star";
                    Set2Star();
                }
                else if (_Score >= Level3.Score1StarHard)
                {
                    textStar = "1 Star";
                    Set1Star();
                }
                else if (_Score < Level3.Score1StarHard)
                {
                    textStar = "0 Star";

                }
                textElementStar.text = textStar;
            }
        }


        void Set1Star()
        {
            if (setStar1 == false)
            {
                SetStar1();
                setStar1 = true;
            }
        }
        void Set2Star()
        {
            if (setStar2 == false)
            {
                SetStar1();
                Invoke("SetStar2", 1f);
                setStar2 = true;
            }
        }
        void Set3Star()
        {
            if (setStar3 == false)
            {
                SetStar1();
                Invoke("SetStar2", 1f);
                Invoke("SetStar3", 2f);
                setStar3 = true;
            }
        }

        void SetStar1()
        {
            Star1.SetTrigger("Star1Play");
            Invoke("playSoundStar", 0.8f);
        }
    
        void SetStar2()
        {
            Star2.SetTrigger("Star2Play");
            Invoke("playSoundStar", 0.8f);
        }
        void SetStar3()
        {
            Star3.SetTrigger("Star3Play");
            Invoke("playSoundStar", 0.8f);
        }

        void playSoundStar()
        {
            FindObjectOfType<AudioManager>().Play("Star");
        }
    }
}