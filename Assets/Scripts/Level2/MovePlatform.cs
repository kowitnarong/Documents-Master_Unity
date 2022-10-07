using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject ObjTransform;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "ThirdPersonPlayer1")
        {
            Player1.transform.parent = ObjTransform.transform;
        }
        if (other.gameObject.name == "ThirdPersonPlayer2")
        {
            Player2.transform.parent = ObjTransform.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "ThirdPersonPlayer1")
        {
            Player1.transform.parent = null;
        }
        if (other.gameObject.name == "ThirdPersonPlayer2")
        {
            Player2.transform.parent = null;
        }
    }
}
