using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class TimeDocumentSet : MonoBehaviour
    {
        [SerializeField] protected TimeDocumentSetting m_TimeSettings;

        [HideInInspector] public float Timer1;
        [HideInInspector] public float Timer2;
        [HideInInspector] public float Timer3;
        [HideInInspector] public float Timer4;

        // Start is called before the first frame update
        void Awake()
        {
            if (SelectPlayer.countOfPlayer == 1)
            {
                if (DifficultSelect.LevelSelect == "Easy")
                {
                    Timer1 = m_TimeSettings.Doc1TimeEasy;
                    Timer2 = m_TimeSettings.Doc2TimeEasy;
                    Timer3 = m_TimeSettings.Doc3TimeEasy;
                    Timer4 = m_TimeSettings.Doc4TimeEasy;
                }
                else if (DifficultSelect.LevelSelect == "Normal")
                {
                    Timer1 = m_TimeSettings.Doc1TimeNormal;
                    Timer2 = m_TimeSettings.Doc2TimeNormal;
                    Timer3 = m_TimeSettings.Doc3TimeNormal;
                    Timer4 = m_TimeSettings.Doc4TimeNormal;
                }
                else if (DifficultSelect.LevelSelect == "Hard")
                {
                    Timer1 = m_TimeSettings.Doc1TimeHard;
                    Timer2 = m_TimeSettings.Doc2TimeHard;
                    Timer3 = m_TimeSettings.Doc3TimeHard;
                    Timer4 = m_TimeSettings.Doc4TimeHard;
                }
            }
            else if (SelectPlayer.countOfPlayer == 2)
            {
                if (DifficultSelect.LevelSelect == "Easy")
                {
                    Timer1 = m_TimeSettings.Doc1TimeEasy - m_TimeSettings.TimeDeduct2Player;
                    Timer2 = m_TimeSettings.Doc2TimeEasy - m_TimeSettings.TimeDeduct2Player;
                    Timer3 = m_TimeSettings.Doc3TimeEasy - m_TimeSettings.TimeDeduct2Player;
                    Timer4 = m_TimeSettings.Doc4TimeEasy - m_TimeSettings.TimeDeduct2Player;
                }
                else if (DifficultSelect.LevelSelect == "Normal")
                {
                    Timer1 = m_TimeSettings.Doc1TimeNormal - m_TimeSettings.TimeDeduct2Player;
                    Timer2 = m_TimeSettings.Doc2TimeNormal - m_TimeSettings.TimeDeduct2Player;
                    Timer3 = m_TimeSettings.Doc3TimeNormal - m_TimeSettings.TimeDeduct2Player;
                    Timer4 = m_TimeSettings.Doc4TimeNormal - m_TimeSettings.TimeDeduct2Player;
                }
                else if (DifficultSelect.LevelSelect == "Hard")
                {
                    Timer1 = m_TimeSettings.Doc1TimeHard - m_TimeSettings.TimeDeduct2Player;
                    Timer2 = m_TimeSettings.Doc2TimeHard - m_TimeSettings.TimeDeduct2Player;
                    Timer3 = m_TimeSettings.Doc3TimeHard - m_TimeSettings.TimeDeduct2Player;
                    Timer4 = m_TimeSettings.Doc4TimeHard - m_TimeSettings.TimeDeduct2Player;
                }
            }
        }
    }
}