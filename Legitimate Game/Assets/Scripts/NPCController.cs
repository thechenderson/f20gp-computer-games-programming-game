using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{

public Transform agentTarget;
NavMeshAgent navigateTo;


    void Start()
    {
        navigateTo = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navigateTo.SetDestination(agentTarget.position);
    }
}
