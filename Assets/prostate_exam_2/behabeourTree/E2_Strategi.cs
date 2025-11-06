using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

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
    
    
    // Startegi 1
    public class IdleStrategy : IE2_Strategies
    {
        public E2_Slime ThisSlime;
        private float _indexCurrentTime;

        // constructor idle
        public IdleStrategy(E2_Slime newSlime)
        {
            this.ThisSlime = newSlime;
            _indexCurrentTime = 0;
        }
        public E2_Node.Status Process()
        {
            if (ThisSlime.chargeTime < _indexCurrentTime)
            {
                return E2_Node.Status.Success;
            }
            
            ThisSlime.gameObject.transform.transform.Rotate(new Vector3(0, 1, 0));
            _indexCurrentTime += Time.deltaTime;
            return E2_Node.Status.Running;
        }

        public void Reset()
        {
            _indexCurrentTime = 0;
        }
    }
    
    // strategi 2
    public class GoTOdirty : IE2_Strategies
    {
        public E2_Slime ThisSlime;
        private int _currentDirty;
        public GoTOdirty(E2_Slime newSlime)
        {
            this.ThisSlime = newSlime;
            _currentDirty = Random.Range(0, ThisSlime.waypoints.Count);
        }
        public E2_Node.Status Process()
        {
            float currentDistance = Vector3.Distance(ThisSlime.gameObject.transform.position, ThisSlime.waypoints[_currentDirty].position);
            if (currentDistance < ThisSlime.maxDistance)
            {
                return E2_Node.Status.Success;
            }
            ThisSlime.agent.SetDestination(ThisSlime.waypoints[_currentDirty].transform.position);
            return E2_Node.Status.Running;
        }
        public void Reset()
        {
            _currentDirty = Random.Range(0, ThisSlime.waypoints.Count);
        }
    }
    // strategi 3
    public class Cleaning : IE2_Strategies
    {
        public E2_Slime ThisSlime;
        private float _indexCurrentTime;
        public Cleaning(E2_Slime newSlime)
        {
            this.ThisSlime = newSlime;
        }
        public E2_Node.Status Process()
        {
            if (_indexCurrentTime > ThisSlime.cleanTime)
            {
                return E2_Node.Status.Success;
            }
            ThisSlime.gameObject.transform.transform.Rotate(new Vector3(0, 1, 0));
            _indexCurrentTime += Time.deltaTime;
            return E2_Node.Status.Running;
        }
        public void Reset()
        {
            _indexCurrentTime = 0;
        }
    }
    // strategi 4 
    public class GoToHouse : IE2_Strategies
    {
        public E2_Slime ThisSlime;
        public GoToHouse(E2_Slime newSlime)
        {
            this.ThisSlime = newSlime;
        }
        public E2_Node.Status Process()
        {
            float currentDistance = Vector3.Distance(ThisSlime.gameObject.transform.position, ThisSlime.House.position);
            if (currentDistance < ThisSlime.maxDistance)
            {
                return E2_Node.Status.Success;
            }
            ThisSlime.agent.SetDestination(ThisSlime.House.position);
            return E2_Node.Status.Running;
        }

        public void Reset()
        {
            
        }
    }
}