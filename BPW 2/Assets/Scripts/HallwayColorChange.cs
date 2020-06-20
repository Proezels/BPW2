using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayColorChange : MonoBehaviour
{
    public ColorTrigger trigger;

    SpriteRenderer render;
    Color newColor;

    void Start()
    {
        render = GetComponent <SpriteRenderer>();
        render.color = Color.white;    
    }


    void Update()
    {
        if (trigger.insidePanel == true)
        {
            render.color = Color.grey;
        }
        else if (trigger.insidePanel == false)
        {
            render.color = Color.white;
        }
    }
}
