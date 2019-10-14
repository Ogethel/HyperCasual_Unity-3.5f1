using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSOData : MonoBehaviour
{
    //Manage Scriptable Object Data
    public IntData data;
    private IntData newData;

    private void Start()
    {
        newData = Instantiate(data);
    }
}
