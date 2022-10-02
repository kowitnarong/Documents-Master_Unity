using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class Device2_1 : DevicePath
    {
        public override void PlaySoundWorking()
        {
            if (AudioManager.SFxOn)
            {
                FindObjectOfType<AudioManager>().Play("Scanner");
            }
        }
    }
}