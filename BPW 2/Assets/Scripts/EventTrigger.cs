using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTrigger : MonoBehaviour
{
    Material material;
    public TurnPage turnPage;
    public bool UmbrellaGet = false;
    public bool UmbrellaGone = false;
    float fadeOut = 1f;
    Animator animator;

    public GameObject PCam;
    public GameObject MCam;

    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;   
        animator = GetComponent<Animator>();
  
    }

    void Update()
    {
        
        if (turnPage.pageTurn == true)
        {
            PCam.SetActive(false);
            MCam.SetActive(true);
        }

        if (turnPage.AniEnd == true)
        { 
            PCam.SetActive(true);
            MCam.SetActive(false);
        }
    }

    void LateUpdate()
    {        
        material.SetFloat("_Fade", fadeOut);
        
        if (UmbrellaGet == true)
                {
                    fadeOut -= Time.deltaTime;

                    if (fadeOut <= 0f)
                    {
                        fadeOut = 0f;
                        UmbrellaGone = true;
                    }
                }
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Player" && UmbrellaGet == false)
        {
            UmbrellaGet = true;
        }
    }
}
