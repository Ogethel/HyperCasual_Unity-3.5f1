using System;
using UnityEngine;

public class EndGameClass : MonoBehaviour
{
    public GameAction gameActionObj;
    private void OnMouseDown()
    {
        gameActionObj.Raise();
    }
}
