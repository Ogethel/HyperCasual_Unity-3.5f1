using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    private WaitForSeconds wfs;
    public float holdTime = 0.1f;

    public bool CanRun { get; set; } = true;
    
    public UnityEvent OnRunEvent;
    private void Awake()
    {
        wfs = new WaitForSeconds(holdTime);
    }

    public void Run()
    {
        StartCoroutine(OnStart());
    }
    
    private IEnumerator OnStart()
    {
        while (CanRun)
        {
            OnRunEvent.Invoke();
            yield return wfs;
        }
    }
}