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
        // Start is called before the first frame update
        public void SetPlayerThenMove(int sceneID)
        {
            SceneManager.LoadScene(sceneID);
            SelectLevel(level);
            LevelSelect = _tempLevel;
            Debug.Log(LevelSelect);
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

        public void BackSelectPlayer()
        {
            SceneManager.LoadScene("PlayerSelect");
        }
    }
}