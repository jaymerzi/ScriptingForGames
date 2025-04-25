using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PatrolAI : MonoBehaviour
{
    public Transform[] waypoints;
    public Transform player;
    private int currentWaypointIndex;
    private NavMeshAgent agent;
    private int playerDetected = 1;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        if (waypoints.Length > 0)
        {
            agent.SetDestination(waypoints[0].position);
        }
        //agent.updateRotation = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (playerDetected == 1)
        {
            if (agent.remainingDistance < agent.stoppingDistance)
            {
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
                agent.SetDestination(waypoints[currentWaypointIndex].position);
            }
        }
        else
        {
            agent.SetDestination(player.position);
        }
    }

    public void Chase()
    {
        playerDetected *= -1;
    }
}