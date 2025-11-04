using System;
using UnityEngine;

public class Condicion : ScriptableObject
{
    public virtual bool Check(StateMachine stateMachine)
    {
        return false;
    }
}

[System.Serializable]
public class Transition
{
    public Condicion Condicion;
    public State State;
}