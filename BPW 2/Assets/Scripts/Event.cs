using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventFade : MonoBehaviour
{
    public EventTrigger trigger;
    Material material;
    float fadeIn = 0f;
    bool faded = false;

    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;     
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.UmbrellaGet == true)
        {
           
            fadeIn += Time.deltaTime;

                if (fadeIn >= 1f)
                {
                    fadeIn = 1f;
                    faded = true;
                } 
        }
        
        material.SetFloat("_Fade", fadeIn);
    }
}
