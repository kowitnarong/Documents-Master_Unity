using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpeed : MonoBehaviour
{
    private Vector3 _rotation = new Vector3(0f, 100f, 0f);
    float direction;
    bool bounce = true;
    void Start()
    {
        direction = Random.Range(-0.05f, 0.05f);
        Invoke("TurnOffBounce", 0.1f);
    }
    // Update is called once per frame
    void Update()
    {
        if (bounce)
        {
            transform.position = new Vector3(transform.position.x + direction, transform.position.y + 0.05f, transform.position.z + direction);
        }
        transform.Rotate(_rotation * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "ThirdPersonPlayer")
        {
            ThirdPersonMovement.speed = 13;
            Destroy(this.gameObject);
        }
    }


    void TurnOffBounce()
    {
        bounce = false;
    }
}
