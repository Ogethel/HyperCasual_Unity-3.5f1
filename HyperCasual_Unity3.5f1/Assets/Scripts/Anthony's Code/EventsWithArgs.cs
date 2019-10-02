using UnityEngine;
using UnityEngine.Events;

public class FloatEvent : UnityEvent<float>
{
	
}

public class EventsWithArgs : MonoBehaviour
{
	public FloatEvent eventWithFloat;

	private void Start()
	{
		eventWithFloat = new FloatEvent();
		eventWithFloat.AddListener(PassFloat);
	}
	
	void Update () {
		eventWithFloat.Invoke(10f);
	}

	private void OnMouseDown()
	{
		eventWithFloat.RemoveListener(PassFloat);
	}

	private void PassFloat(float arg0)
	{
		print(arg0);
	}
}