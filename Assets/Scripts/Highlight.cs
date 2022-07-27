using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlight : MonoBehaviour
{
    public Outline outline;

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("collision : " + collision.gameObject.name);
        if (collision.gameObject.name == "ThirdPersonPlayer1" || collision.gameObject.name == "ThirdPersonPlayer2")
        {
            outline.OutlineWidth = 4;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "ThirdPersonPlayer1" || collision.gameObject.name == "ThirdPersonPlayer2")
        {
            outline.OutlineWidth = 0;
        }
    }
}
