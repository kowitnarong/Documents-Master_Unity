using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class MenuScene : MonoBehaviour
    {
        private void Awake()
        {
            Screen.SetResolution(1366, 768, false);
            ScreenResolution.ResoSelected = "1,366 × 768";
            ScreenResolution.Fullscreen = false;
        }
    }
}