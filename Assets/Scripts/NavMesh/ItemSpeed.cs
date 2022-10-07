using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameDev3.Project
{
    public class ItemSpeed : MonoBehaviour
    {
        private Vector3 _rotation = new Vector3(0f, 100f, 0f);
        public GameObject Player1;
        public GameObject Player2;
        float direction;
        bool bounce = true;
        void Start()
        {
            Player1 = GameObject.Find("ThirdPersonPlayer1");
            Player2 = GameObject.Find("ThirdPersonPlayer2");
            direction = Random.Range(-0.05f, 0.05f);
            Invoke("TurnOffBounce", 0.05f);
        }
        // Update is called once per frame
        void Update()
        {
            if (bounce)
            {
                transform.position = new Vector3(transform.position.x + direction, transform.position.y + 0.02f, transform.position.z + direction);
            }
            transform.Rotate(_rotation * Time.deltaTime);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "ThirdPersonPlayer1")
            {
                if (collision.gameObject.GetComponent<ThirdPersonMovement>().player == "Player1")
                {
                    Player1.GetComponent<ThirdPersonMovement>().speed = 13f;
                }
                FindObjectOfType<AudioManager>().Play("CollectItem");
                Destroy(gameObject);
            }
            if (collision.gameObject.name == "ThirdPersonPlayer2")
            {
                if (collision.gameObject.GetComponent<ThirdPersonMovement>().player == "Player2")
                {
                    Player2.GetComponent<ThirdPersonMovement>().speed = 13f;
                }
                FindObjectOfType<AudioManager>().Play("CollectItem");
                Destroy(gameObject);
            }
            if (collision.gameObject.name == "Interaction Trigger")
            {
                if (collision.gameObject.tag == "InteractP1")
                {
                    Player1.GetComponent<ThirdPersonMovement>().speed = 13f;
                }
                if (collision.gameObject.tag == "InteractP2")
                {
                    Player2.GetComponent<ThirdPersonMovement>().speed = 13f;
                }
                FindObjectOfType<AudioManager>().Play("CollectItem");
                Destroy(gameObject);
            }
        }


        void TurnOffBounce()
        {
            bounce = false;
        }
    }
}