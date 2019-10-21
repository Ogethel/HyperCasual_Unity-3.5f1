using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PowerUp : ScriptableObject, IRun, ITest
{
    public float Speed { get; set; }
    public void Run()
    {
        Debug.Log("PowerUp");
    }

    public void Run(float f)
    {
        
    }

    public void Test()
    {
        Debug.Log("PowerUp Test");
    }
}
