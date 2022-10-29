using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameDev3.Project
{
    public class PauseMenu : MonoBehaviour
    {
        public static bool GameIsPaused = false;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (GameIsPaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }

        public void Resume()
        {
            var gameflow = GameObject.FindObjectOfType<GameAppFlowManager>();
            gameflow.UnloadScene("PauseScene");
            if (SceneManager.GetSceneByName("HTPScene").isLoaded)
            {
                gameflow.UnloadScene("HTPScene");
            }
            if (SceneManager.GetSceneByName("OptionScene").isLoaded)
            {
                gameflow.UnloadScene("OptionScene");
            }
            Time.timeScale = 1f;
            GameIsPaused = false;
        }

        public void Pause()
        {
            var gameflow = GameObject.FindObjectOfType<GameAppFlowManager>();
            gameflow.LoadSceneAdditive("PauseScene");
            Time.timeScale = 0f;
            GameIsPaused = true;
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}