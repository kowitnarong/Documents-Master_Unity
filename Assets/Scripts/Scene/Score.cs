using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int ScoreGame = 0;
    public static string _Level;

    public string CurrentLevel;

    private void Start()
    {
        _Level = CurrentLevel;
    }

    private void Update()
    {
        if (ScoreGame <= 0)
        {
            ScoreGame = 0;
        }
    }
}
