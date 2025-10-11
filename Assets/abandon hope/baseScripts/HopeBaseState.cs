using UnityEngine;

public class HopeBaseState : ScriptableObject
{
    public Transition[] transitions;
    public virtual void EnterState(HopeStateMachine stateMachine)
    {
        
    }
    public virtual void Update(HopeStateMachine stateMachine)
    {
        
    }
    public virtual void ExitState(HopeStateMachine stateMachine)
    {
        
    }

    public void CheckTransitions(HopeStateMachine stateMachine)
    {
        if (transitions.Length > 0)
        {
            foreach (Transition t in transitions)
            {
                //if (t.Condicion != null && t.Condicion.Check(stateMachine))
                //{
                //    stateMachine.ChangeState(t.State);
                //    break;
                //}
            }
        }
    }
}
