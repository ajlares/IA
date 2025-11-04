using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace BehaviourTree
{
    public class Enemy : MonoBehaviour
    {
        public BehaviourTree tree;
        public NavMeshAgent agent;
        public List<Transform> patrolPoints = new List<Transform>();
        public float patrolSpeed;
        void Start()
        {
            tree = new BehaviourTree("el arboles");
            IStrategies patrolStrategy = new PatrolStrategy(transform, agent, patrolPoints, patrolSpeed);
            tree.AddChild(new Leaf("arboles",patrolStrategy));
            
        }
        void Update()
        {
            tree.Process();
        }
    }
}