using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public ColorTrigger trigger;
    public EventTrigger eventTrigger;
    public FadeEvent eventFade;
    public GameObject PCam;
    public GameObject SCam;

    float timer = 0f;

    SpriteRenderer renderer;
    Color newColor;

    void Start()
    {
        renderer = GetComponent <SpriteRenderer>();
        renderer.color = Color.white;    
    }


    void Update()
    {
        if (trigger.insidePanel == true)
        {
            Debug.Log ("Inside panel");
            renderer.color = Color.white;
            SCam.SetActive(true);
            PCam.SetActive(false);
        }
        else if (trigger.insidePanel == false)
        {
            Debug.Log ("outside panel");
            renderer.color = Color.black;
            SCam.SetActive(false);
            PCam.SetActive(true);
        }

    //tigger camera move when fade happens
        if (eventTrigger.UmbrellaGone == true)
        {
            renderer.color = Color.white;
            SCam.SetActive(true);
            PCam.SetActive(false);
        } 
        
        if (eventFade.faded == true)
        {
            timer = timer + 1f;
            if (timer >= 150)
            {
                eventTrigger.UmbrellaGone = false;
                SCam.SetActive(false);
                PCam.SetActive(true);
            }
        }
    }
}
