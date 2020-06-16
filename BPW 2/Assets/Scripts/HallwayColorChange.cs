using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallwayColorChange : MonoBehaviour
{
    public ColorTrigger trigger;

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
            renderer.color = Color.grey;
        }
        else if (trigger.insidePanel == false)
        {
            Debug.Log ("outside panel");
            renderer.color = Color.white;
        }
    }
}
