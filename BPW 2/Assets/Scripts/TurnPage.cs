using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TurnPage : MonoBehaviour
{
    public GameObject objects;
    public bool pageTurn = false;
    public bool AniEnd = false;
    public GameObject eventObjects;
    public PlayableDirector timeline;

    
    
    void Start()
    {
        timeline = timeline.GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update()
    {
        if (pageTurn == true)
        {            
            objects.SetActive(true);
            eventObjects.SetActive(true);
            timeline.Play();
        }
        
    }

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
