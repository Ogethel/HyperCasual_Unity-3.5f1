using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActionCalls : MonoBehaviour
{
    public float speed = 1f;
    public float rotateSpeed = 10f;
    public float scaleSpeed = .01f;

    private Vector3 location, rotations, scales;
    private UnityAction transformAction;

    private void Start()
    {
        transformAction = OnMove;
    }
    public enum Transformstates
    {
        Move,
        Rotate,
        Scale

    }

    private void OnMouseDown()
    {
       //if (transformAction == OnMove)
           
    }

   

    void Update() //Update should be used to call functions not define them
    {
        transformAction();
    }

    public void OnMove()
    {
        location.x = speed * Time.deltaTime; //Normalize values base on frame rate
        transform.Translate(location);
    }

    public void OnRotate()
    {
        rotations.y = rotateSpeed*Time.deltaTime;
        transform.Rotate(rotations);
    }

    public void OnScale()
    {
        scales.Set(newX: scaleSpeed, newY: scaleSpeed, newZ: scaleSpeed);
        transform.localScale = scales;
    }
}
