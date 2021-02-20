using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCController : MonoBehaviour
{

/*Where the NPC agent should be moving towards i.e. the player*/
public Transform agentTarget;

/*Make an agent that is capable of manouevring the navmesh*/
NavMeshAgent navigateTo;


    void Start()
    {
        /*Gets the navmeshagent component from the object this script is attached to*/
        navigateTo = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Set the intended destination for the agent i.e the players position at this frame*/
        navigateTo.SetDestination(agentTarget.position);
    }
}
