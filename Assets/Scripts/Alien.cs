using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Alien : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent agent;
    public float navigationUpdate;
    private float navigationTime = 0; 

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

 
    void Update()
    {
        navigationTime += Time.deltaTime;
        if (navigationTime > navigationUpdate)
        {
            agent.destination = target.position;
            navigationTime = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
  