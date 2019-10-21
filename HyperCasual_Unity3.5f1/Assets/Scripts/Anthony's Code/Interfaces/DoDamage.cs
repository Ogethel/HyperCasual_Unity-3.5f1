using UnityEngine;
[CreateAssetMenu]
public class DoDamage : ScriptableObject, IRun
{
    public float Speed { get; set; }

    public void Run()
    {
        Debug.Log("DoDamage");
    }

    public void Run(float f)
    {
        
    }
}