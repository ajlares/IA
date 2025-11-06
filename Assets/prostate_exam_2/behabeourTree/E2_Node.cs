using UnityEngine;
using System.Collections.Generic;
using BehaviourTree;

namespace E2_BehaviourTree
{
    public class E2_Sequence : E2_Node
    {
        // cosntructor
        public E2_Sequence(string nodeName) : base(nodeName)
        {
        }

        // override clase process de nodo
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
                        return currentChild == children.Count ? Status.Success : Status.Running;
                        break;
                }
            }

            Reset();
            return Status.Success;
        }

    }

    public class E2_Selector : E2_Node
    {
        // cosntructor
        public E2_Selector(string nodeName) : base(nodeName)
        {
        }

        override public Status Process()
        {
            if (currentChild < children.Count)
            {
                switch (children[currentChild].Process())
                {
                    case Status.Running:
                        return Status.Running;
                        break;
                    case Status.Success:
                        Reset();
                        return Status.Success;
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

    public class E2_Node
    {
        // enum de los status que pued etener el nodo
        public enum Status
        {
            Success,
            Failure,
            Running
        }

        // declaramos el nombre y hacemos que no se pueda modificar 
        public readonly string name;

        // declaramos un status 
        public Status status;

        // declaramos la lista de hijos del nodo 
        public readonly List<E2_Node> children = new List<E2_Node>();

        // numero interno que dice que numero de hijo actual
        protected int currentChild = 0;

        //constructor del nodo
        public E2_Node(string name)
        {
            this.name = name;
        }

        // agregamos hijos a la lista del nodo
        public void AddChild(E2_Node child)
        {
            children.Add(child);
        }

        // creamos la funcion que regresa el status del nodo
        // la cual es una lambda simplificada de: return children[currentChild].Process();
        public virtual Status Process() => children[currentChild].Process();

        //creamos una funcion para resetear todos los nodos 
        public virtual void Reset()
        {
            currentChild = 0;
            foreach (E2_Node child in children)
            {
                child.Reset();
            }
        }
    }

    public class E2_Leaf : E2_Node
    {
        readonly IE2_Strategies strategy;

        // cosntructor 
        public E2_Leaf(string name, IE2_Strategies strategy) : base(name)
        {
            this.strategy = strategy;
        }

        public override Status Process() => strategy.Process();
        public override void Reset() => strategy.Reset();

    }

    public class E2_BehaviourTree : E2_Node
    {
        // cosntructor
        public E2_BehaviourTree(string name) : base(name)
        {
        }

        public override Status Process()
        {
            while (currentChild < children.Count)
            {
                var status = children[currentChild].Process();
                if (status != Status.Success)
                {
                    return status;
                }

                currentChild++;
            }

            return Status.Success;
        }
    }
    
}