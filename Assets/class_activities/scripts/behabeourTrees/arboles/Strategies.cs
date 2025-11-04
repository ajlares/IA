using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviourTree
{
    public interface IStrategies
    {
        Node.Status Process();
        void Reset();
    }

    public class PatrolStrategy : IStrategies
    {
        public Transform entity;
        public NavMeshAgent agent;
        public List<Transform> patrolPoints;
        public float patrolSpeed;
        public int currentIndex;

        private bool isPathCalculated;

        public PatrolStrategy(Transform entity, NavMeshAgent agent, List<Transform> patrolPoints, float patrolSpeed)
        {
            this.entity = entity;
            this.agent = agent;
            this.patrolPoints = patrolPoints;
            this.patrolSpeed = patrolSpeed;
            currentIndex = 0;
        }

        public Node.Status Process()
        {
            if (currentIndex == patrolPoints.Count)
            {
                return Node.Status.Succes;
            }
            var target = patrolPoints[currentIndex];
            agent.SetDestination(target.position);
            entity.LookAt(new Vector3(target.position.x, entity.transform.position.y, target.position.z));

            if (isPathCalculated == true && agent.remainingDistance < 0.1f)
            {
                isPathCalculated = false;
                currentIndex++;
            }

            if (agent.pathPending == true)
            {
                isPathCalculated = true;
            }
            return Node.Status.Running;
        }

        public void Reset()
        {
            currentIndex = 0;
        }
    }
}
