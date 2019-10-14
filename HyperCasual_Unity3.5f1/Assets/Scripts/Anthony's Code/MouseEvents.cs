using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent MouseDownEvent;

    private void OnMouseDown()
    {
        MouseDownEvent.Invoke();
    }
    
}
