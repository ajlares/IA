using System;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AISpav2 : MonoBehaviour
{
    public Transform player;
    public float fleeRange = 3f;
    private NavMeshAgent agent;

    public Vector3[] patrolPoints = new Vector3[3];
    int patrolIndex = 0;

    private void Start()
    {
        gameObject.TryGetComponent(out agent);
    }

    private void Update()
    {
        //Sense
        float distance = Vector3.Distance(transform.position, player.position);
        Ray ray = new Ray(transform.position + (Vector3.up * .5f), player.position);
        Physics.Raycast(ray,out RaycastHit hit );
        bool los = false;
        if (hit.collider)
        {
            if (hit.collider.gameObject.TryGetComponent(out PlayerMovement playah))
            {
                los = true;
            }
        }
        float patrolPointDistance = Vector3.Distance(transform.position, patrolPoints[patrolIndex]);
        if(los == false)
        {
            if(patrolPointDistance < 1f)
            {
                patrolIndex = (patrolIndex+1)%patrolPoints.Length;
            }
        }
        //plan
        if (los)
        {
            if (distance > fleeRange)
            {
                agent.SetDestination(player.position);
            }
            else
            {
                Vector3 dir = player.position - transform.position;
                Vector3 fleePos = transform.position + dir * 5;
                agent.SetDestination(fleePos);
            }
        }
        else
        {
            agent.SetDestination(patrolPoints[patrolIndex]);
        }
    }
}
