using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameDev3.Project
{
    public class SummaryChangeScene : MonoBehaviour
    {
        public void NextLevel()
        {
            if (Score._Level == "Level1")
            {
                SceneManager.LoadScene("Level2");
            }
            else if (Score._Level == "Level2")
            {
                SceneManager.LoadScene("Level3");
            }
        }

        public void RestartLevel()
        {
            if (Score._Level == "Level1")
            {
                SceneManager.LoadScene("Level1");
            }
            else if (Score._Level == "Level2")
            {
                SceneManager.LoadScene("Level2");
            }
        }
    }
}