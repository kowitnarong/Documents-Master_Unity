using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class PauseMenu : MonoBehaviour
    {
        public static bool GameIsPaused = false;

        public GameObject pauseMenuUI;
        public GameObject optionMenuUI;
        public GameObject HTPMenuUI;


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
            pauseMenuUI.SetActive(false);
            optionMenuUI.SetActive(false);
            HTPMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
        public void Option()
        {
            pauseMenuUI.SetActive(false);
            optionMenuUI.SetActive(true);
            HTPMenuUI.SetActive(false);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
        public void Howtoplay()
        {
            optionMenuUI.SetActive(false);
            pauseMenuUI.SetActive(false);
            HTPMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
        public void Back()
        {
            optionMenuUI.SetActive(false);
            pauseMenuUI.SetActive(true);
            HTPMenuUI.SetActive(false);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
        public void Pause()
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
        public void QuitGame()
        {
            Application.Quit();
        }
    }
}