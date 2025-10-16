using UnityEngine;

public class HellBaseState : ScriptableObject
{
    public HellCondition.HellTransition[] transitions;
    public virtual void EnterState(HellStateMachine stateMachine)
    {
        
    }
    public virtual void UpdateState(HellStateMachine stateMachine)
    {
        
    }
    public virtual void ExitState(HellStateMachine stateMachine)
    {
        
    }

    public void CheckTransitions(HellStateMachine stateMachine)
    {
        if (transitions.Length > 0)
        {
            foreach ( HellCondition.HellTransition hell in transitions)
            {
                //if (hell.condition != null && hell.condition.CheckCondition(stateMachine))
                //{
                //    stateMachine.ChangeState(hell.state);
                //    break;
                //}
            }
        }
    }
}
