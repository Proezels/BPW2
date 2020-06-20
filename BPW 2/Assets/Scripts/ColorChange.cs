using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class ColorChange : MonoBehaviour
{
    public ColorTrigger trigger;
    public EventTrigger eventTrigger;
    public FadeEvent eventFade;
    public GameObject PCam;
    public GameObject SCam;
    public GameObject hallDark;

    public Light2D lights;

    float timer = 0f;

    SpriteRenderer render;
    SpriteRenderer eventRender;
    Color newColor;

    void Start()
    {
        render = GetComponent <SpriteRenderer>();
        render.color = Color.white;  
        if (eventFade != null)
        {
            eventRender = eventFade.GetComponent <SpriteRenderer>();  
        }
    }


    void Update()
    {
        //triggers lights & camera change inside panels
        if (trigger.insidePanel == true)
        {
            render.color = Color.white;
            SCam.SetActive(true);
            PCam.SetActive(false);            
            hallDark.SetActive(true);
            lights.enabled = true;
            if (eventFade != null && eventFade.faded == true)
            {
                eventRender.color = Color.white;
            }

        }
        else if (trigger.insidePanel == false)
        {
            render.color = Color.black;
            SCam.SetActive(false);
            PCam.SetActive(true);       
            hallDark.SetActive(false);
            lights.enabled = false;
            if (eventFade != null && eventFade.faded == true)
            {
                eventRender.color = Color.black;
            }
     
        }

    //trigger camera move when fade happens
        
        if (eventTrigger != null && eventTrigger.UmbrellaGone == true)
        {
            render.color = Color.white;
            eventRender.color = Color.white;
            SCam.SetActive(true);
            PCam.SetActive(false);
        } 
        
        if (eventFade != null && eventFade.faded == true)
        {
            timer = timer + 1f;
            if (timer >= 150)
            {
                if (eventTrigger != null)
                {
                    eventTrigger.UmbrellaGone = false;
                    SCam.SetActive(false);
                    PCam.SetActive(true);
                    render.color = Color.black;
                    eventRender.color = Color.black;
                }
            }
        }
    }
}
