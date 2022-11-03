using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameDev3.Project
{
    public class DifficultSelect : MonoBehaviour
    {
        public enum Level { Easy, Normal, Hard };
        public Level level;
        static public string LevelSelect;
        private string _tempLevel;

        public Animator Transition;

        private string _sceneID;

        void Start()
        {
            if (Score._Level == "MenuScene")
            {
                _sceneID = "Level1";
                Debug.Log(_sceneID);
            }
        }

        public void TransitionIn()
        {
            Transition.SetBool("End", true);
        }

        public void SetPlayerThenMove()
        {
            SelectLevel(level);
            LevelSelect = _tempLevel;
            Debug.Log(LevelSelect);
            TransitionIn();
            Invoke("LoadScene", 3f);
        }

        public void SelectLevel(Level level)
        {
            switch (level)
            {
                case Level.Easy:
                    _tempLevel = "Easy";
                    break;
                case Level.Normal:
                    _tempLevel = "Normal";
                    break;
                case Level.Hard:
                    _tempLevel = "Hard";
                    break;
            }
        }

        private void LoadScene()
        {
            SceneManager.LoadScene(_sceneID, LoadSceneMode.Single);
        }
    }
}