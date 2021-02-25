using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class celebrateEscapeController : MonoBehaviour
{
    public Transform agentTarget;

    NavMeshAgent navigateTo;


 void Start()
    {
        /*Gets the navmeshagent component from the object this script is attached to*/
        navigateTo = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (FindObjectOfType<GameManager>().levelComplete == true)
        {
            navigateTo.SetDestination(agentTarget.position);
        }

    }
}
