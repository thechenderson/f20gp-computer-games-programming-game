using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCFleeController : MonoBehaviour
{

    private NavMeshAgent fleeAgent;
    public Transform Player;
    public float distanceToKeep = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        fleeAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        float currentDistanceFromPlayer = Vector3.Distance(transform.position, Player.  position);

        if (currentDistanceFromPlayer < distanceToKeep)
        {
            Vector3 directionOfPlayer = transform.position - Player.position;
            Vector3 oppositeDirection = transform.position + directionOfPlayer;

            fleeAgent.SetDestination(oppositeDirection);
        }
    }
}
