using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public Text textElementScore;
    static public string textScore;
    void Update()
    {
        textScore = "" + ItemSystem.score.ToString();

        textElementScore.text = textScore;
    }
}