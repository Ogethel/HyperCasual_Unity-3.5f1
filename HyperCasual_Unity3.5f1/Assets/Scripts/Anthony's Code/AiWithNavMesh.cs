using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AiWithNavMesh : MonoBehaviour, IRun, ITest
{
    private NavMeshAgent agent;
    public Transform player;

    public Transform destination;
    void Start()
    {
        destination = transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = player;
    }

    private void OnTriggerExit(Collider other)
    {
        destination = transform;
    }

    void Update()
    {
        agent.destination = destination.position;
    }

    public float Speed { get; set; }

    public void Run()
    {
        
    }

    public void Run(float f)
    {
        
    }

    public void Test()
    {
        
    }
}
