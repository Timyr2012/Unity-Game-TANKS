using UnityEngine;
using UnityEngine.AI;

public class WaypointPatrol : MonoBehaviour
{
    public Transform[] waypoints;
    private NavMeshAgent agent;
    private int currentPointIndex = 0;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (waypoints.Length > 0)
        {
            agent.SetDestination(waypoints[0].position);
        }
    }

    void Update()
    {
        if (agent.remainingDistance < 0.5f && !agent.pathPending)
        {
            currentPointIndex++;
            if (currentPointIndex >= waypoints.Length)
                currentPointIndex = 0;

            // аналог - currentPointIndex = (currentPointIndex + 1) % waypoints.Length;

            agent.SetDestination(waypoints[currentPointIndex].position);
        }
    }
}