using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameDev3.Project
{
    public class MenuScene : MonoBehaviour
    {
        private void Awake()
        {
            Screen.SetResolution(1366, 768, false);
            ScreenResolution.ResoSelected = "1,366 × 768";
            ScreenResolution.Fullscreen = false;
        }

        public void StartGame()
        {
            SceneManager.LoadScene("PlayerSelect");
        }
        public void ExitGame()
        {
            Application.Quit();
        }
    }
}