using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorTrigger : MonoBehaviour
{
    public bool insidePanel = false;

    void Start()
    {
    }


     void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Player" && insidePanel == false)
        {
            insidePanel = true;
        }
        else if (other.name == "Player" && insidePanel == true)
        {
            insidePanel = false;
        }
    }





}
