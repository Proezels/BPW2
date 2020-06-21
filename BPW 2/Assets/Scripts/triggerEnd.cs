using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerEnd : MonoBehaviour
{

    public FadeEvent eventFade;
    public GameObject whiteOut;
    Material material;
    float fadeOut = 0f;

    public bool exiting = false;

    void Start()
    {
        material = whiteOut.GetComponent<SpriteRenderer>().material;
    }

    void LateUpdate()
    {
        if (exiting == true)
        {
            material.SetFloat("_Fade", fadeOut);
                fadeOut += Time.deltaTime;
                if (fadeOut >= 1f)
                {
                    fadeOut = 1f;
                    SceneManager.LoadScene("End");
                }
        }
    }


    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Player" && eventFade.ending == true)
        {
            exiting = true;
        }
    }

}
