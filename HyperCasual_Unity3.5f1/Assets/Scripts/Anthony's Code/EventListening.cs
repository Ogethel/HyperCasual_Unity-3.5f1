using UnityEngine;
using UnityEngine.Events;

public class EventListening : MonoBehaviour, IListen
{
    public UnityEvent Event { get; set; }
    public Object IRunObj;
    public IRun NewIRunObj { get; set; }

    public void Start()
    {
        Event = new UnityEvent();
        NewIRunObj = IRunObj as IRun;
        Event.AddListener(NewIRunObj.Run);
    }
    
    private void OnMouseDown()
    {
        Event.Invoke();
        Event.RemoveListener(NewIRunObj.Run);
    }
}
