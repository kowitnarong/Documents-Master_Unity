using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.InputSystem;


public class ThirdPersonMovement : MonoBehaviour
{
    [SerializeField]
    private float _gravity = 9.8f;

    public CharacterController controller;
    public string player;

    static public float speed = 10f;
    bool speedTurnBack = false;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    float horizontal1;
    float vertical1;
    float horizontal2;
    float vertical2;

    public void OnHorizontal1(InputValue value)
    {
        horizontal1 = value.Get<float>();
    }
    
    public void OnVertical1(InputValue value)
    {
        vertical1 = value.Get<float>();
    }

    public void OnHorizontal2(InputValue value)
    {
        horizontal2 = value.Get<float>();
    }

    public void OnVertical2(InputValue value)
    {
        vertical2 = value.Get<float>();
    }

    void Update()
    {
        if (player == "Player1")
        {
            Vector3 direction = new Vector3(horizontal1, 0f, vertical1).normalized;

            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                direction.y -= _gravity;
                controller.Move(direction * speed * Time.deltaTime);
            }
        }
        if (player == "Player2")
        {
            Vector3 direction = new Vector3(horizontal2, 0f, vertical2).normalized;

            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                direction.y -= _gravity;
                controller.Move(direction * speed * Time.deltaTime);
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
        ThirdPersonMovement.speed = 10;
        speedTurnBack = false;
    }
}
