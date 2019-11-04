using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodayneClass : MonoBehaviour
{
    public GameAction GameActionObj;

    public void Talk()
    {
        Debug.Log("Rodayne");
    }

    private void Awake()
    {
        GameActionObj.action += Talk;
    }

    /*public AnthonyClass snape;

    public MartyClass santa;

    public void Talk()
    {
        Debug.Log("Rodayne");
    }
    // Start is called before the first frame update
    void Start()
    {
        snape.Yell();
        santa.FMinus();
    }*/
}
