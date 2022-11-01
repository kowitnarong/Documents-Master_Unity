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

        public void TransitionIn()
        {
            Transition.SetBool("End", true);
        }

        public void SetPlayerThenMove(int sceneID)
        {
            SelectLevel(level);
            LevelSelect = _tempLevel;
            Debug.Log(LevelSelect);
            TransitionIn();
            StartCoroutine(LoadLevelScene(sceneID));
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

        public IEnumerator LoadLevelScene(int sceneID)
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(sceneID);
        }
    }
}