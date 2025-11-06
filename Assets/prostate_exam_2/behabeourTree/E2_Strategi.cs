using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace E2_BehaviourTree
{
    public interface IE2_Strategies
    {
        E2_Node.Status Process();

        void Reset()
        {
            // si no hay reinicio no explota
        }
    }
    public class Condition : IE2_Strategies
    {
        readonly Func<bool> _predicateFunc;

        public Condition(Func<bool> predicateFunc)
        {
            this._predicateFunc = predicateFunc;
        }
        public E2_Node.Status Process() => _predicateFunc() ? E2_Node.Status.Success : E2_Node.Status.Failure;
    }

    public class ActionStrategy : IE2_Strategies
    {
        readonly Action _action;

        public ActionStrategy(Action action)
        {
            this._action = action;
        }

        public E2_Node.Status Process()
        {
            _action();
            return E2_Node.Status.Success;
        }
        
    }
    
    
    // leaf 1
    public class IdleStrategy : IE2_Strategies
    {
        public GameObject ThisGameObject;
        public NavMeshAgent agent;
        public float chargeTime;
        public float indexCurrentTime;

        // constructor idle
        public IdleStrategy(GameObject newGameObject, NavMeshAgent newAgent, float newChargeTime)
        {
            this.ThisGameObject = newGameObject;
            this.agent = newAgent;
            this.chargeTime = newChargeTime;
            indexCurrentTime = 0;
        }
        public E2_Node.Status Process()
        {
            if (chargeTime < indexCurrentTime)
            {
                return E2_Node.Status.Success;
            }
            
            ThisGameObject.transform.transform.Rotate(new Vector3(0, 1, 0));
            indexCurrentTime += Time.deltaTime;
            return E2_Node.Status.Running;
        }

        public void Reset()
        {
            indexCurrentTime = 0;
        }
    }
}