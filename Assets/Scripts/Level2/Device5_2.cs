using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class Device5_2 : DevicePath
    {
        public override void PlaySoundWorking()
        {
            FindObjectOfType<AudioManager>().Play("Scanner");
        }
    }
}