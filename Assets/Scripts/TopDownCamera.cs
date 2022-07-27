using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCamera : MonoBehaviour
{
    public GameObject Player2;

    private Transform Target;
    public float distance = 18;
    public float angle = 0;
    public float height = 38f;
    private float smoothness = 0f;
    private Vector3 referenceVelocity;

    public List<Transform> targets;

    public Vector3 offset = new Vector3( 0f, 0f, 0f);

    // 1 player distance 18 height 38
    // 2 player distance 22 height 50 y 37 z -16

    void LateUpdate()
    {
        if (SelectPlayer.countOfPlayer == 2)
        {
            if (targets.Count == 0)
            {
                return;
            }

            Vector3 centerPoint = GetCenterPoint();

            Vector3 newPosition = centerPoint + offset;

            transform.position = newPosition;
        }
    }

    Vector3 GetCenterPoint()
    {
        if (targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }

        return bounds.center;
    }

    void Start()
    {
        if (SelectPlayer.countOfPlayer == 1)
        {
            targets.Add(GameObject.FindGameObjectWithTag("Player1").transform);
            distance = 18f;
            height = 38f;
            offset = new Vector3(0f, 0f, 0f);
        }
        if (SelectPlayer.countOfPlayer == 2)
        {
            Player2.SetActive(true);
            targets.Add(GameObject.FindGameObjectWithTag("Player1").transform);
            targets.Add(GameObject.FindGameObjectWithTag("Player2").transform);

            distance = 22f;
            height = 50f;
            offset = new Vector3(0f, 37f, -16f);
        }
        Target = GameObject.FindGameObjectWithTag("Player1").transform;
        tdCam();
    }

    // Update is called once per frame
    private void tdCam()
    {
        if (!Target)
        {
            return;
        }

        Vector3 worldPos = (Vector3.forward * -distance) + (Vector3.up * height);
        Vector3 angleVector = Quaternion.AngleAxis(angle, Vector3.up) * worldPos;
        Vector3 flatPos = Target.position;
        flatPos.y = 0;
        Vector3 finalPos = flatPos + angleVector;

        transform.position = Vector3.SmoothDamp(transform.position, finalPos, ref referenceVelocity, smoothness);
        transform.LookAt(flatPos);
    }

    private void Update()
    {
        tdCam();
    }
}
