using UnityEngine;
[CreateAssetMenu]
public class PlayerHealth : ScriptableObject, IRun
{
    public float Speed { get; set; }

    public void Run()
    {
        Debug.Log("PlayerHealth");
    }

    public void Run(float f)
    {
        
    }
}