using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTrigger : MonoBehaviour
{
    public bool insidePanel = false;
    public bool p1 = false;
    public bool p2 = false;
    public bool p3 = false;
    public bool p5 = false;

    public GameObject PCam;
    public GameObject SCam;

    float fadeOut = 0f;
    Material material;

    public GameObject Ladder;



    void Start()
    {
        if (Ladder != null)
        {
            material = Ladder.GetComponent<SpriteRenderer>().material;  
        }
    }


 void LateUpdate()
    {        
        // spawn next ladder
        if (Ladder != null)
        {
            material.SetFloat("_Fade", fadeOut);
            if (p1 == true || p2 == true || p3 == true || p5 == true)
                    {
                        fadeOut += Time.deltaTime;
                        if (PCam != null && SCam != null)
                        {
                            PCam.SetActive(false);
                            SCam.SetActive(true);
                        }
                        if (fadeOut >= 1f)
                        {
                            fadeOut = 1f;
                            if (PCam != null && SCam != null)
                            {
                                PCam.SetActive(true);
                                SCam.SetActive(false);
                            }
                        }

                    }
        }
    }
    
    
     void OnTriggerEnter2D (Collider2D other)
    {
        // check if enter panel
        if (other.name == "Player" && insidePanel == false)
        {
            insidePanel = true;
           
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        //check if exit panel
        if (other.name == "Player" && insidePanel == true)
        {
            insidePanel = false; 
            // detect that theyve been to the panel in order to trigger the next ladder
            if (gameObject.name == "P1Detect")
            {
                p1 = true;

            }
            if (gameObject.name == "P2Detect")
            {
                p2 = true;
                p1 = false;
            }
            if (gameObject.name == "P3Detect")
            {
                p3 = true;
                p2 = false;
            }
  
            if (gameObject.name == "P5Detect")
            {
                p5 = true;
                p3 = false;
            }
        }
    }

    





}
