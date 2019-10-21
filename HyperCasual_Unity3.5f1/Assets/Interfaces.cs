using UnityEngine.Events;
using UnityEngine;
public interface IRun
{
     float Speed { get; set; }
     void Run();
     void Run(float f);
}

public interface ITest
{
     void Test();
}

public interface IListen
{
     UnityEvent Event { get; set; } 
     IRun NewIRunObj { get; set; } 
     void Start();
}

public interface ITrigger
{
     void OnTriggerEnter(Collider obj);
}