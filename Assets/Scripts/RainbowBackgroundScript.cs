using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainbowBackgroundScript : MonoBehaviour
{
    public float colorChangeSpeed = 1f;
    void Update()
    {
        float time = Time.time * colorChangeSpeed;

        float hue = Mathf.PingPong(time, 1f);

        Camera.main.backgroundColor = Color.HSVToRGB(hue, 1f, 1f);
    }
}