using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class TimeDocumentSet1 : MonoBehaviour
    {
        public float Doc1TimeEasy;
        public float Doc2TimeEasy;
        public float Doc3TimeEasy;
        public float Doc4TimeEasy;
        public float Doc1TimeNormal;
        public float Doc2TimeNormal;
        public float Doc3TimeNormal;
        public float Doc4TimeNormal;
        public float Doc1TimeHard;
        public float Doc2TimeHard;
        public float Doc3TimeHard;
        public float Doc4TimeHard;
        [Header("---------------------")]
        public float TimeDeduct2Player;

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
                    Timer1 = Doc1TimeEasy;
                    Timer2 = Doc2TimeEasy;
                    Timer3 = Doc3TimeEasy;
                    Timer4 = Doc4TimeEasy;
                }
                else if (DifficultSelect.LevelSelect == "Normal")
                {
                    Timer1 = Doc1TimeNormal;
                    Timer2 = Doc2TimeNormal;
                    Timer3 = Doc3TimeNormal;
                    Timer4 = Doc4TimeNormal;
                }
                else if (DifficultSelect.LevelSelect == "Hard")
                {
                    Timer1 = Doc1TimeHard;
                    Timer2 = Doc2TimeHard;
                    Timer3 = Doc3TimeHard;
                    Timer4 = Doc4TimeHard;
                }
            }
            else if (SelectPlayer.countOfPlayer == 2)
            {
                if (DifficultSelect.LevelSelect == "Easy")
                {
                    Timer1 = Doc1TimeEasy - TimeDeduct2Player;
                    Timer2 = Doc2TimeEasy - TimeDeduct2Player;
                    Timer3 = Doc3TimeEasy - TimeDeduct2Player;
                    Timer4 = Doc4TimeEasy - TimeDeduct2Player;
                }
                else if (DifficultSelect.LevelSelect == "Normal")
                {
                    Timer1 = Doc1TimeNormal - TimeDeduct2Player;
                    Timer2 = Doc2TimeNormal - TimeDeduct2Player;
                    Timer3 = Doc3TimeNormal - TimeDeduct2Player;
                    Timer4 = Doc4TimeNormal - TimeDeduct2Player;
                }
                else if (DifficultSelect.LevelSelect == "Hard")
                {
                    Timer1 = Doc1TimeHard - TimeDeduct2Player;
                    Timer2 = Doc2TimeHard - TimeDeduct2Player;
                    Timer3 = Doc3TimeHard - TimeDeduct2Player;
                    Timer4 = Doc4TimeHard - TimeDeduct2Player;
                }
            }
        }
    }
}