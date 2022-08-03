using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SummaryScore : MonoBehaviour
{
    public Text textElementScore;
    public Text textElementStar;
    private string textScore;
    private string textStar;
    private int _Score;
    void Start()
    {
        _Score = ItemSystem.score;
    }
    void Update()
    {
        textScore = "Score : " + _Score.ToString(); ;
        textElementScore.text = textScore;
        CalculateStar();
    }

    void CalculateStar()
    {
        if (_Score >= 800)
        {
            textStar = "1 Star";
        }
        else if (_Score < 800)
        {
            textStar = "0 Star";
        }
        textElementStar.text = textStar;
    }
}
