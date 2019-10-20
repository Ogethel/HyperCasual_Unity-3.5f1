using System;
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