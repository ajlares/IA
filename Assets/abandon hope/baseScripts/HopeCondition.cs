using UnityEngine;

public class HopeCondition : ScriptableObject
{
    public virtual bool CheckCondition(HopeStateMachine stateMachine)
    {
        return false;
    }
    [System.Serializable]
    public class Transition
    {
        public HopeCondition condition;
        public HopeBaseState state;
    }
}