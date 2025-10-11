using System.Collections.Generic;
using UnityEngine;

public abstract class State : ScriptableObject
{
    public Transition[] transitions;

    public virtual void EnterState(StateMachine stateMachine)
    {
        
    }

    public virtual void ExitState(StateMachine stateMachine)
    {
        
    }

    public virtual void Update(StateMachine stateMachine)
    {
        
    }

    public void CheckTransitions(StateMachine stateMachine)
    {
        if (transitions.Length > 0)
        {
            foreach (Transition t in transitions)
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
