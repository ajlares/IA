using UnityEngine;

public class HellCondition : ScriptableObject
{
    public virtual bool CheckCondition(HellStateMachine stateMachine)
    {
        return false;
    }
    [System.Serializable]
    public class HellTransition
    {
        public HopeCondition condition;
        public HopeBaseState state;
    }
}
