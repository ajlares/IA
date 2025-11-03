using UnityEngine;

public class E2_BaseState : ScriptableObject
{
    public E2_Transition[] transitions;

    public virtual void EnterState(E2_StateMachine stateMachine)
    {
        
    }

    public virtual void ExitState(E2_StateMachine stateMachine)
    {
        
    }

    public virtual void Update(E2_StateMachine stateMachine)
    {
        
    }

    public void CheckTransitions(E2_StateMachine stateMachine)
    {
        if (transitions.Length > 0)
        {
            foreach (E2_Transition t in transitions)
            {
                if (t.Condicion != null && t.Condicion.Check(stateMachine))
                {
                    stateMachine.ChangeState(t.State);
                    break;
                }
            }
        }
    }
}
