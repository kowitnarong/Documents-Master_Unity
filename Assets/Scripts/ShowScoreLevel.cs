using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameDev3.Project
{
    public class ShowScoreLevel : MonoBehaviour
    {
        public SummaryScoreScriptable Level1;
        public SummaryScoreScriptable Level2;

        public Text textElementScore1;
        public Text textElementScore2;
        public Text textElementScore3;

        void Awake()
        {
            CheckLevel();
        }

        private void CheckLevel()
        {
            if (Score._Level == "Level1")
            {
                CheckLevelDifficultLevel1();
            }
            else if (Score._Level == "Level2")
            {
                CheckLevelDifficultLevel2();
            }
        }

        private void CheckLevelDifficultLevel1()
        {
            if (DifficultSelect.LevelSelect == "Easy")
            {
                SetTextScoreLevel1Easy();
            }
            else if (DifficultSelect.LevelSelect == "Normal")
            {
                SetTextScoreLevel1Normal();
            }
            else if (DifficultSelect.LevelSelect == "Hard")
            {
                SetTextScoreLevel1Hard();
            }
        }

        private void CheckLevelDifficultLevel2()
        {
            if (DifficultSelect.LevelSelect == "Easy")
            {
                SetTextScoreLevel2Easy();
            }
            else if (DifficultSelect.LevelSelect == "Normal")
            {
                SetTextScoreLevel2Normal();
            }
            else if (DifficultSelect.LevelSelect == "Hard")
            {
                SetTextScoreLevel2Hard();
            }
        }

        private void SetTextScoreLevel1Easy()
        {
            textElementScore1.text = Level1.Score1StarEasy.ToString();
            textElementScore2.text = Level1.Score2StarEasy.ToString();
            textElementScore3.text = Level1.Score3StarEasy.ToString();
        }

        private void SetTextScoreLevel1Normal()
        {
            textElementScore1.text = Level1.Score1StarNormal.ToString();
            textElementScore2.text = Level1.Score2StarNormal.ToString();
            textElementScore3.text = Level1.Score3StarNormal.ToString();
        }

        private void SetTextScoreLevel1Hard()
        {
            textElementScore1.text = Level1.Score1StarHard.ToString();
            textElementScore2.text = Level1.Score2StarHard.ToString();
            textElementScore3.text = Level1.Score3StarHard.ToString();
        }

        // Level2
        private void SetTextScoreLevel2Easy()
        {
            textElementScore1.text = Level2.Score1StarEasy.ToString();
            textElementScore2.text = Level2.Score2StarEasy.ToString();
            textElementScore3.text = Level2.Score3StarEasy.ToString();
        }

        private void SetTextScoreLevel2Normal()
        {
            textElementScore1.text = Level2.Score1StarNormal.ToString();
            textElementScore2.text = Level2.Score2StarNormal.ToString();
            textElementScore3.text = Level2.Score3StarNormal.ToString();
        }

        private void SetTextScoreLevel2Hard()
        {
            textElementScore1.text = Level2.Score1StarHard.ToString();
            textElementScore2.text = Level2.Score2StarHard.ToString();
            textElementScore3.text = Level2.Score3StarHard.ToString();
        }
    }
}