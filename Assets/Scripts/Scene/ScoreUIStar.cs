using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace GameDev3.Project
{
    public class ScoreUIStar : MonoBehaviour
    {
        public SummaryScoreScriptable ScorePassLevel;

        public TextMeshProUGUI textElement1Star;
        public TextMeshProUGUI textElement2Star;
        public TextMeshProUGUI textElement3Star;

        private Animator animator;
        private Button button;
        private bool WideOut = false;

        private void Awake()
        {
            animator = GetComponentInChildren<Animator>();
            button = GetComponentInChildren<Button>();
            CheckLevelDifficultLevel1();
        }
        
        public void WideStarUI()
        {
            if (WideOut == false)
            {
                animator.SetTrigger("WideOut");
                button.interactable = false;
                Invoke("EnableButton", 1f);
                WideOut = true;
            }
            else
            {
                animator.SetTrigger("WideIn");
                button.interactable = false;
                Invoke("EnableButton", 1f);
                WideOut = false;
            }
        }

        private void EnableButton()
        {
            button.interactable = true;
        }

        private void CheckLevelDifficultLevel1()
        {
            if (DifficultSelect.LevelSelect == "Easy")
            {
                SetTextScoreLevelEasy();
            }
            else if (DifficultSelect.LevelSelect == "Normal")
            {
                SetTextScoreLevelNormal();
            }
            else if (DifficultSelect.LevelSelect == "Hard")
            {
                SetTextScoreLevelHard();
            }
        }

        private void SetTextScoreLevelEasy()
        {
            textElement1Star.text = ": " + ScorePassLevel.Score1StarEasy.ToString();
            textElement2Star.text = ": " + ScorePassLevel.Score2StarEasy.ToString();
            textElement3Star.text = ": " + ScorePassLevel.Score3StarEasy.ToString();
        }

        private void SetTextScoreLevelNormal()
        {
            textElement1Star.text = ": " + ScorePassLevel.Score1StarNormal.ToString();
            textElement2Star.text = ": " + ScorePassLevel.Score2StarNormal.ToString();
            textElement3Star.text = ": " + ScorePassLevel.Score3StarNormal.ToString();
        }

        private void SetTextScoreLevelHard()
        {
            textElement1Star.text = ": " + ScorePassLevel.Score1StarHard.ToString();
            textElement2Star.text = ": " + ScorePassLevel.Score2StarHard.ToString();
            textElement3Star.text = ": " + ScorePassLevel.Score3StarHard.ToString();
        }   
    }
}