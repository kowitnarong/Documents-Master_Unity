using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class Highlight : MonoBehaviour
    {
        public Outline outline;

        private void OnCollisionEnter(Collision collision)
        {
            //Debug.Log("collision : " + collision.gameObject.name);
            if (collision.gameObject.name == "Interaction Trigger")
            {
                outline.OutlineWidth = 4;
            }
        }

        private void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.name == "Interaction Trigger")
            {
                outline.OutlineWidth = 0;
            }
        }
    }
}