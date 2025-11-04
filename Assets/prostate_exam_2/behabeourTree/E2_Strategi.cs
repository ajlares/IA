using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace E2_BehaviourTree
{
    public interface IE2_Strategies
    {
        E2_Node.Status Process();
        void Reset();
    }

    // estos son los estados?
    
    public class IdleStrategy : IE2_Strategies
    {
        public E2_Node.Status Process()
        {
            return new E2_Node.Status();
        }

        public void Reset()
        {
            
        }
    }
}