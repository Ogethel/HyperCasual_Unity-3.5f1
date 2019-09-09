using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameAction GameActionObj;
    public UnityEvent handlerEvent;
    private void Start ()
    {
        GameActionObj.action += Action;
    }
    private void Action()
    {
        handlerEvent.Invoke();
    }

    
}
