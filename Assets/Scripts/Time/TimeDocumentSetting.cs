using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    [CreateAssetMenu(menuName = "GameDev3/TimeDocumentSetting", fileName = "TimeDocumentPreset")]
    public class TimeDocumentSetting : ScriptableObject
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
    }
}