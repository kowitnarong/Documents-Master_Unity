using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameDev3.Project
{
    public class MenuScene : MonoBehaviour
    {
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