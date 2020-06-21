using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startAni : MonoBehaviour
{
    public GameObject PCam;
    public ColorTrigger trigger1;
    public ColorTrigger trigger2;
    public ColorTrigger trigger3;
    public ColorTrigger trigger4;
    public ColorTrigger trigger5;

    public GameObject whiteBG;

    void Start()
    {
        trigger1.insidePanel = true;
        trigger2.insidePanel = true;
        trigger3.insidePanel = true;
        trigger4.insidePanel = true;
        trigger5.insidePanel = true;
    }

    void AniStop()
    {
        trigger1.insidePanel = false;
        trigger2.insidePanel = false;
        trigger3.insidePanel = false;
        trigger4.insidePanel = false;
        trigger5.insidePanel = false;
        gameObject.SetActive(false);
        PCam.SetActive(true);
        whiteBG.SetActive(false);
    }
}
