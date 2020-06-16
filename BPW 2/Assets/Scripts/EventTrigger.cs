using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    Material material;
    public bool UmbrellaGet = false;
    public bool UmbrellaGone = false;
    float fadeOut = 1f;

    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;        
    }

    void Update()
    {
        if (UmbrellaGet == true)
        {
            fadeOut -= Time.deltaTime;

            if (fadeOut <= 0f)
            {
                fadeOut = 0f;
                UmbrellaGone = true;
            }
        }

        material.SetFloat("_Fade", fadeOut);
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Player" && UmbrellaGet == false)
        {
            UmbrellaGet = true;
        }
    }
}
