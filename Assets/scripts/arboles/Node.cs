using UnityEngine;
using System.Collections.Generic;

namespace BehaviourTree
{
    public class Sequence : Node
    {
        public Sequence(string nodeName) : base(nodeName){ }
        public override Status Process()
        {
            if (currentChild < children.Count)
            {
                switch (children[currentChild].Process())
                {
                    case Status.Running:
                        return Status.Running; 
                        break;
                    case Status.Failure:
                        Reset();
                        return Status.Failure;
                        break;
                    default:
                        currentChild++;
                        return currentChild == children.Count ? Status.Succes : Status.Running;
                        break;
                }
            }
            Reset();
            return Status.Succes;
        }
    }

    public class Selector : Node
    {
        public Selector(string nodeName) : base(nodeName) { }
        override public Status Process()
        {
            if (currentChild < children.Count)
            {
                switch (children[currentChild].Process())
                {
                    case Status.Running:
                        return Status.Running;
                        break;
                    case Status.Succes: 
                        Reset();
                        return Status.Succes; 
                        break;
                    default:
                        currentChild++;
                        return currentChild == children.Count ? Status.Failure : Status.Running;
                    break;
                }
            }
            Reset();
            return Status.Failure;
        }
    }
    # region Base
    public class Node
    {
        public enum Status
        {
            Succes,
            Failure,
            Running
        }

        public readonly string name;
        public readonly Status status;
        
        public readonly List<Node> children = new List<Node>();
        protected int currentChild = 0;

        public Node(string name)
        {
            this.name = name;
        }

        public void AddChild(Node child)
        {
            children.Add(child);
        }
        
        public virtual Status Process() => children[currentChild].Process();

        public virtual void Reset()
        {
            currentChild = 0;
            foreach (Node child in children)
            {
                child.Reset();
            }
        }
    }

    public class Leaf : Node
    {
        readonly IStrategies strategy;

        public Leaf(string name, IStrategies strategy) : base(name)
        {
            this.strategy = strategy;
        }

        public override Status Process() => strategy.Process();
        public override void Reset() => strategy.Reset();
    }

    public class BehaviourTree : Node
    {
        public BehaviourTree(string name) : base(name) { }

        public override Status Process()
        {
            while (currentChild < children.Count)
            {
                var status = children[currentChild].Process();
                if (status != Status.Succes)
                {
                    return status;
                }
                currentChild++;
            }
            return Status.Succes;
        }
    }
    #endregion
}