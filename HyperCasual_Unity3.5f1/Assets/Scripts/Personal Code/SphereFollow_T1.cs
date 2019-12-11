using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SphereFollow_T1 : MonoBehaviour
{
    public GameObject target = null;
    

    private NavMeshAgent nma = null;
    public float speed = 10f;
    
    void Start()
    {
        nma = this.GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("Player");
        nma.speed = speed;
    }

    void Update()
    {
        nma.SetDestination(target.transform.position);

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Tag");
            Destroy(gameObject);
        }
    }
}
