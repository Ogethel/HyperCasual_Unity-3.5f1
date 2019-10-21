using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehaviours : MonoBehaviour
{
    public UnityEvent StartEvent;
    void Start()
    {
        StartEvent.Invoke();
    }
}