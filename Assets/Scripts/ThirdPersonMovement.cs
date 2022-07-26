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

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    float horizontal;
    float vertical;

    public void OnHorizontal(InputValue value)
    {
        horizontal = value.Get<float>();
    }
    
    public void OnVertical(InputValue value)
    {
        vertical = value.Get<float>();
    }

    void Update()
    {
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            direction.y -= _gravity;
            controller.Move(direction * speed * Time.deltaTime);
        }


    }
}
