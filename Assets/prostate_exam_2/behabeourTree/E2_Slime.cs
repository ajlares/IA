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
        public float maxDistance;
        [Header("---------- House ----------")]
        public Transform House;
        [Header("---------- IndexTimes----------")]
        public float chargeTime;
        public float cleanTime;

        private void Start()
        {
            agent.speed = speed;
            // creamos el arbol
            slimeTree = new E2_BehaviourTree("Slime Tree");
            // creamos la primera estrategia 
            IE2_Strategies idleStrategy = new IdleStrategy(this);
            // creamos la segunda estartegia
            IE2_Strategies goToDirty = new GoTOdirty(this);
            // creamos la tercera estrategia 
            IE2_Strategies cleaningStrategie = new Cleaning(this);
            //creamos la cuarta estrategia
            IE2_Strategies goToHouse = new GoToHouse(this);
            
            slimeTree.AddChild(new E2_Leaf("idle",idleStrategy));
            slimeTree.AddChild(new E2_Leaf("go to dirty", goToDirty));
            slimeTree.AddChild(new E2_Leaf("cleaning",cleaningStrategie));
            slimeTree.AddChild(new E2_Leaf("go to house", goToHouse));
        }
        private void Update()
        {
            slimeTree.Process();
        }
    }
}

