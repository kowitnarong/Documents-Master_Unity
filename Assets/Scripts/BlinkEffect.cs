using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkEffect : MonoBehaviour
{
    private Color startColor;
    public Color endColor = Color.white;
    [Range(0f, 100f)]
    public float speed = 0;

    Renderer ren;

    private void Awake()
    {
        ren = GetComponent<Renderer>();
        startColor = ren.material.color;
    }

    private void Update()
    {
        ren.material.color = Color.Lerp(startColor, endColor, Mathf.PingPong(Time.time * speed, 1));
    }
}
