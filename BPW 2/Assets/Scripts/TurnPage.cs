using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TurnPage : MonoBehaviour
{
    public GameObject objects;
    public GameObject objectsAni;
    public bool pageTurn = false;
    public bool AniEnd = false;
    public GameObject eventObjects;
    public PlayableDirector timeline;

    public GameObject PCam;
    public GameObject MCam;

    
    
    void Start()
    {
        timeline = timeline.GetComponent<PlayableDirector>();
    }

    void Update()
    {// activate events & triggers and start timeline
        if (pageTurn == true)
        {            
            objectsAni.SetActive(true);
            eventObjects.SetActive(true);
            timeline.Play();
            PCam.SetActive(false);
            MCam.SetActive(true);
        }

//activates other objects after timeline ends && also triggers cameras
        if (AniEnd == true)
        {
            objects.SetActive(true);
            objectsAni.SetActive(false);
            PCam.SetActive(true);
            MCam.SetActive(false);
        }
        
    }
//detect the end of the animation & stop the animation
    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.name == "Player")
        {
            pageTurn = true;
        } 
    }

    void OnEnable()
    {
        timeline.stopped += OnPlayableDirectorStopped;
    }

    void OnPlayableDirectorStopped(PlayableDirector aDirector)
    {
        if (timeline == aDirector)
        {
            AniEnd = true;
            timeline.enabled = false;
        }
    }

    void OnDisable() 
    {
        timeline.stopped -= OnPlayableDirectorStopped;
    }
}
