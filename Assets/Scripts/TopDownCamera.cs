using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class TopDownCamera : MonoBehaviour
    {
        public GameObject Player2;

        private Transform Target;
        public float distance = 18;
        public float angle = 0;
        public float height = 38f;
        public float smoothness = 0f;
        private Vector3 referenceVelocity;

        public List<Transform> targets;

        public Vector3 offset = new Vector3(0f, 0f, 0f);

        // 1 player distance 18 height 38
        // 2 player distance 25 height 42.9 y 40 z 1.6

        void LateUpdate()
        {
            if (PauseMenu.GameIsPaused == false)
            {
                if (SelectPlayer.countOfPlayer == 2)
                {
                    if (targets.Count == 0)
                    {
                        return;
                    }

                    Vector3 centerPoint = GetCenterPoint();

                    Vector3 newPosition = centerPoint + offset;

                    Vector3 worldPos = Vector3.forward * -distance + Vector3.up * height;
                    Vector3 angleVector = Quaternion.AngleAxis(angle, Vector3.up) * worldPos;
                    Vector3 flatPos = newPosition;
                    flatPos.y = 0;
                    Vector3 finalPos = flatPos + angleVector;

                    transform.position = Vector3.SmoothDamp(transform.position, finalPos, ref referenceVelocity, smoothness);
                    transform.LookAt(flatPos);
                }
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
            ////////////////////////////////////
            SelectPlayer.countOfPlayer = 2;
            ////////////////////////////////////
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

                distance = 25f;
                height = 42.9f;
                offset = new Vector3(0f, 40f, 1.6f);
            }
            Target = GameObject.FindGameObjectWithTag("Player1").transform;
            if (SelectPlayer.countOfPlayer == 1)
            {
                tdCam();
            }
        }

        // Update is called once per frame
        private void tdCam()
        {
            if (!Target)
            {
                return;
            }

            Vector3 worldPos = Vector3.forward * -distance + Vector3.up * height;
            Vector3 angleVector = Quaternion.AngleAxis(angle, Vector3.up) * worldPos;
            Vector3 flatPos = Target.position;
            flatPos.y = 0;
            Vector3 finalPos = flatPos + angleVector;

            transform.position = Vector3.SmoothDamp(transform.position, finalPos, ref referenceVelocity, smoothness);
            transform.LookAt(flatPos);
        }

        private void Update()
        {
            if (PauseMenu.GameIsPaused == false)
            {
                if (SelectPlayer.countOfPlayer == 1)
                {
                    tdCam();
                }
            }
        }
        private void FixedUpdate()
        {

            if (PauseMenu.GameIsPaused == true)
            {
                if (SelectPlayer.countOfPlayer == 2)
                {
                    if (targets.Count == 0)
                    {
                        return;
                    }

                    Vector3 centerPoint = GetCenterPoint();

                    Vector3 newPosition = centerPoint + offset;
                    Vector3 worldPos = Vector3.forward * -distance + Vector3.up * height;
                    Vector3 angleVector = Quaternion.AngleAxis(angle, Vector3.up) * worldPos;
                    Vector3 flatPos = newPosition;
                    flatPos.y = 0;
                    Vector3 finalPos = flatPos + angleVector;

                    transform.position = Vector3.SmoothDamp(transform.position, finalPos, ref referenceVelocity, smoothness);
                    transform.LookAt(flatPos);
                }
            }
        }
    }
}