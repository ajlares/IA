using UnityEngine;

public class E2_BaseCondition : ScriptableObject
{
    public virtual bool Check(E2_StateMachine stateMachine)
    {
        return false;
    }
}
[System.Serializable]
public class E2_Transition
{
    public E2_BaseCondition Condicion;
    public E2_BaseState State;
}