using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class GlobalLightControl : MonoBehaviour
{
    
    public Light2D lt;

    [SerializeField] [Range(0f, 1f)] float transitionDuration;

    public Color color1;
    public Color color2;
    public Color color3;
    private float currentIntensity;
    
    private Color currentColor = Color.white;

    public Mood mood = Mood.normal;

    void Start()
    {
        //lt.color = currentColor;
        lt.intensity = currentIntensity;
    }

    void Update()
    {
        //lt.color = currentColor;
        lt.intensity = currentIntensity;

        switch (mood)
        {
            case Mood.normal:
                //currentColor = Color.Lerp(currentColor, color1, transitionDuration);
                currentIntensity = Mathf.Lerp(currentIntensity, (float)0.8, transitionDuration);
                break;
            case Mood.angry:
                //currentColor = Color.Lerp(currentColor, color1, transitionDuration);
                currentIntensity = Mathf.Lerp(currentIntensity, (float)0.5, transitionDuration);
                break;
            case Mood.sad:
                //currentColor = Color.Lerp(currentColor, color1, transitionDuration);
                currentIntensity = Mathf.Lerp(currentIntensity, (float)0.3, transitionDuration);
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {       
        if (collision.tag == "Light Trigger 1")
            mood = Mood.angry;
        else if (collision.tag == "Light Trigger 2")
            mood = Mood.sad;
        else if (collision.tag == "Light Trigger 3")
            mood = Mood.normal;
    }

    public enum Mood //State pattern
    {
        normal,
        angry,
        sad
    }
}
