using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Debugger : MonoBehaviour
{
    public void OnDebug(string message)
    {
        Debug.Log(message);
    }

    public void OnDebug(int number)
    {
        Debug.Log(number);
    }
    
}
