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
    
    
    // Startegi 1
    public class IdleStrategy : IE2_Strategies
    {
        public E2_Slime ThisSlime;
        private float _indexCurrentTime;

        // constructor idle
        public IdleStrategy(E2_Slime newGameObject)
        {
            this.ThisSlime = newGameObject;
            _indexCurrentTime = 0;
        }
        public E2_Node.Status Process()
        {
            if (ThisSlime.chargeTime < _indexCurrentTime)
            {
                _indexCurrentTime = 0;
                ThisSlime.chargeComplete = true;
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
        public GoTOdirty(E2_Slime newSlime)
        {
            this.ThisSlime = newSlime;
        }
        public E2_Node.Status Process()
        {
            return E2_Node.Status.Success;
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
                _indexCurrentTime = 0;
                ThisSlime.chargeComplete = false;
                return E2_Node.Status.Success;
            }
            ThisSlime.gameObject.transform.transform.Rotate(new Vector3(0, 1, 0));
            _indexCurrentTime += Time.deltaTime;
            return E2_Node.Status.Running;
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
            return E2_Node.Status.Success;
        }
    }
}