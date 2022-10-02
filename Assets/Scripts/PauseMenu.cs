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
        public AudioManager _audio;

        void Start()
        {
            _audio = GameObject.FindWithTag("Audio").GetComponent<AudioManager>();
        }

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
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
        public void Option()
        {
            pauseMenuUI.SetActive(false);
            optionMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
        public void Back()
        {
            optionMenuUI.SetActive(false);
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
        void Pause()
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
        public void QuitGame()
        {
            Application.Quit();
        }

        public void AdjectBGVolume(float volume)
        {
            _audio.BGVolume = volume;
        }

        public void AdjectSFx(bool OnOff)
        {
            AudioManager.SFxOn = OnOff;
        }
    }
}