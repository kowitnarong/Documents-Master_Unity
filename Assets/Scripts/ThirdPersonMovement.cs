using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.InputSystem;

namespace GameDev3.Project
{
    public class ThirdPersonMovement : MonoBehaviour
    {
        [SerializeField]
        private float _gravity = 9.8f;
        public PlayerControl playerControls;

        public CharacterController controller;
        public string player;

        static public float speed = 10f;
        bool speedTurnBack = false;

        public float turnSmoothTime = 0.1f;
        float turnSmoothVelocity;

        private InputAction Horizontal1;
        private InputAction Vertical1;
        private InputAction Horizontal2;
        private InputAction Vertical2;

        float horizontal1;
        float vertical1;
        float horizontal2;
        float vertical2;

        public ParticleSystem dust;

        private void Awake()
        {
            playerControls = new PlayerControl();
        }

        private void OnEnable()
        {
            Horizontal1 = playerControls.Gameplay.Horizontal1;
            Horizontal1.Enable();
            Vertical1 = playerControls.Gameplay.Vertical1;
            Vertical1.Enable();
            Horizontal2 = playerControls.Gameplay.Horizontal2;
            Horizontal2.Enable();
            Vertical2 = playerControls.Gameplay.Vertical2;
            Vertical2.Enable();
        }

        private void OnDisable()
        {
            Horizontal1.Disable();
            Vertical1.Disable();
            Horizontal2.Disable();
            Vertical2.Disable();
        }

        void Update()
        {
            horizontal1 = Horizontal1.ReadValue<float>();
            vertical1 = Vertical1.ReadValue<float>();
            horizontal2 = Horizontal2.ReadValue<float>();
            vertical2 = Vertical2.ReadValue<float>();

            if (player == "Player1" && PauseMenu.GameIsPaused == false)
            {
                Vector3 direction = new Vector3(horizontal1, 0f, vertical1).normalized;
                Debug.Log(direction.magnitude);
                if (direction.magnitude >= 0.1f)
                {
                    float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                    float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                    transform.rotation = Quaternion.Euler(0f, angle, 0f);

                    direction.y -= _gravity;
                    controller.Move(direction * speed * Time.deltaTime);
                    CreateDust();
                }
            }
            if (player == "Player2" && PauseMenu.GameIsPaused == false)
            {
                Vector3 direction = new Vector3(horizontal2, 0f, vertical2).normalized;
                if (direction.magnitude >= 0.1f)
                {
                    float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                    float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                    transform.rotation = Quaternion.Euler(0f, angle, 0f);

                    direction.y -= _gravity;
                    controller.Move(direction * speed * Time.deltaTime);
                    CreateDust();
                }
            }
            if (speed == 13 && speedTurnBack == false)
            {
                Invoke("defaultSpeed", 8);
                speedTurnBack = true;
            }
        }
        void defaultSpeed()
        {
            speed = 10;
            speedTurnBack = false;
        }
        void CreateDust()
        {
            dust.Play();
        }
    }
}