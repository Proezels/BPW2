using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderMove : MonoBehaviour
{
    private CharacterController2D thePlayer;

    // Start is called before the first frame update
    void Start()
    {
     thePlayer = FindObjectOfType<CharacterController2D>();   
    }

    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Player")
        {
            thePlayer.onLadder = true;
        }
    }

    void OnTriggerExit2D (Collider2D other)
    {
        if (other.name == "Player")
        {
            thePlayer.onLadder = false;
        }
    }

}
