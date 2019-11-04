using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnthonyClass : MonoBehaviour
{
    
    public GameAction GameActionObj;

    public void Yell()
    {
        Debug.Log("Anthony");
    }

    private void Awake()
    {
        GameActionObj.action += Yell;
    }
    /*public RodayneClass larry;

    public MartyClass santa;

    public void Yell()
    {
        Debug.Log("Anthony");
    }
    // Start is called before the first frame update
    void Start()
    {
        larry.Talk();
        santa.FMinus();
    }*/
}
