using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public ColorTrigger trigger;
    public GameObject PCam;
    public GameObject SCam;

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
    }
}
