using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SummaryScorePreset", menuName = "GameDev3/SummaryScorePreset", order = 0)]
public class SummaryScoreScriptable : ScriptableObject
{
    public int Score1StarEasy;
    public int Score2StarEasy;
    public int Score3StarEasy;
    [Header("----------------------------")]
    public int Score1StarNormal;
    public int Score2StarNormal;
    public int Score3StarNormal;
    [Header("----------------------------")]
    public int Score1StarHard;
    public int Score2StarHard;
    public int Score3StarHard;
}
