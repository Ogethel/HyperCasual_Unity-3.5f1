using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AiWithNavMesh : MonoBehaviour
{
    private NavMeshAgent agent;

    public Transform player;

    public Transform destination;
    // Start is called before the first frame update
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

    // Update is called once per frame
    void Update()
    {
        agent.destination = destination.position;
    }
}
