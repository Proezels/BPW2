using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeEvent : MonoBehaviour
{
    public EventTrigger trigger;
    Material material;
    float fadeIn = 0f;
    public bool faded = false;
    public bool ending = false;

    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;     
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.UmbrellaGone == true)
        {   
            fadeIn += Time.deltaTime;

                if (fadeIn >= 1f)
                {
                    fadeIn = 1f;
                    faded = true;
                } 
        }

        if (faded == true && gameObject.name == "p1.event")
        {
            ending = true;
        }

        
        material.SetFloat("_Fade", fadeIn);
    }
}
