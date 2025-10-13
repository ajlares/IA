using UnityEngine;

public class HopeBaseState : ScriptableObject
{
    public HopeCondition.HopeTransition[] transitions;
    public virtual void EnterState(HopeStateMachine stateMachine)
    {
        
    }
    public virtual void UpdateState(HopeStateMachine stateMachine)
    {
        
    }
    public virtual void ExitState(HopeStateMachine stateMachine)
    {
        
    }

    public void CheckTransitions(HopeStateMachine stateMachine)
    {
        if (transitions.Length > 0)
        {
            foreach (HopeCondition.HopeTransition hp in transitions)
            {
                if (hp.condition != null && hp.condition.CheckCondition(stateMachine))
                {
                    stateMachine.ChangeState(hp.state);
                    break;
                }
            }
        }
    }
}
