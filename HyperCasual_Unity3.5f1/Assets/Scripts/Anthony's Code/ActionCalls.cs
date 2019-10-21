using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionCalls : MonoBehaviour
{
	public float speed = 1f, rotateSpeed = 10f, scaleSpeed = 0.02f;
	private Vector3 location, rotations, scales;
	private List<UnityAction> actions;
	private int i;
	
	private void Awake()
	{
		actions = new List<UnityAction> {OnMove, OnRotate, OnScale};
	}
	private void OnMouseDown()
	{
		if (i == actions.Count-1)
			i = 0;
		else
			i++;
	}

	private void Update ()
	{
		actions[i]();
	}

	private void OnMove()
	{
		location.x = speed * Time.deltaTime;
		transform.Translate(location);
	}

	private void OnRotate()
	{
		rotations.y = rotateSpeed * Time.deltaTime;
		transform.Rotate(rotations);
	}

	private void OnScale()
	{
		scales.Set(scaleSpeed,scaleSpeed,scaleSpeed);
		transform.localScale += scales;
	}
}