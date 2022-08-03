using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator Transition;
    public int IndexSceneID;

    // Update is called once per frame
    void Update()
    {
        TransitionIn();
    }

    void TransitionIn()
    {
        if (TimerOrder.GameIsTimeOut == true)
        {
            Transition.SetBool("End", true);
            StartCoroutine(LoadSummaryScene());
        }
    }

    public IEnumerator LoadSummaryScene()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(IndexSceneID);
    }
}
