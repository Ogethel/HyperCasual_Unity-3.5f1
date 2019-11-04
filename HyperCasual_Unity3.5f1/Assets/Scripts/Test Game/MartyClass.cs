using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartyClass : MonoBehaviour
{
    public GameAction GameActionObj;

    public void FMinus()
    {
        Debug.Log("Marty");
    }

    private void Awake()
    {
        GameActionObj.action += FMinus;
    } 
    
    /*public RodayneClass larry;

    public AnthonyClass snape;

    public void FMinus()
    {
        Debug.Log("Marty");
    }
    // Start is called before the first frame update
    void Start()
    {
        larry.Talk();
        snape.Yell();
    }*/
}
