using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameDev3.Project
{
    public class SummaryChangeScene : MonoBehaviour
    {
        public Animator Transition;

        public void NextLevel()
        {
            if (Score._Level == "Level1")
            {
                StartCoroutine(LoadLevelScene("Level2"));
            }
            else if (Score._Level == "Level2")
            {
                StartCoroutine(LoadLevelScene("Level3"));
            }
        }

        public void RestartLevel()
        {
            if (Score._Level == "Level1")
            {
                StartCoroutine(LoadLevelScene("Level1"));
            }
            else if (Score._Level == "Level2")
            {
                StartCoroutine(LoadLevelScene("Level2"));
            }
        }

        public IEnumerator LoadLevelScene(string scene)
        {
            Transition.SetBool("End", true);
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(scene);
        }
    }
}