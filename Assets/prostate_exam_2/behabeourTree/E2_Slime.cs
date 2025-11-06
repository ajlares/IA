using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace E2_BehaviourTree
{
    public class E2_Slime : MonoBehaviour
    {
        public E2_BehaviourTree slimeTree;
        [Header("---------- waypoints ----------")]
        public NavMeshAgent agent;
        public List<Transform> waypoints;
        public float speed;
        [Header("---------- House ----------")]
        public Transform House;
        [Header("---------- IndexTimes----------")]
        public float chargeTime;
        public bool chargeComplete;
        public float cleanTime;

        private void Start()
        {
            // creamos el arbol
            slimeTree = new E2_BehaviourTree("Slime Tree");
            // creamos la primera estrategia 
            IE2_Strategies IdleStrategy = new IdleStrategy(this);
            // creamos la segunda estrategia 
            
            slimeTree.AddChild(new E2_Leaf("idle",IdleStrategy));
        }
        private void Update()
        {
            slimeTree.Process();
        }
    }
}

