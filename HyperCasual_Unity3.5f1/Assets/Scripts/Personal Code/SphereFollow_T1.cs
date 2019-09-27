using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SphereFollow_T1 : MonoBehaviour
{
    public GameObject target = null;

    private NavMeshAgent nma = null;
    public float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        nma = this.GetComponent<NavMeshAgent>();
        nma.speed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        nma.SetDestination(target.transform.position);

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerTower")
        {
            Debug.Log("Tag");
        }
    }
}
