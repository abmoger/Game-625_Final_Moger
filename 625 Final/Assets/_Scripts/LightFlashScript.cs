using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightFlashScript : MonoBehaviour
{
    Light2D lt;

    public float transitionDuration;

    public Color color1;
    public Color color2;

    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float t = Mathf.PingPong(Time.time, transitionDuration) / transitionDuration;
        lt.color = Color.Lerp(color1, color2, t);
    }
}
