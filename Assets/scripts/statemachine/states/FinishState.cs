using UnityEngine;
[CreateAssetMenu(fileName = "FinishState", menuName = "FSM/States/FinishState.")]
public class FinishState : State
{
    public override void Update(StateMachine stateMachine)
    {
        stateMachine.gameObject.transform.Rotate(new Vector3(0,1,0));
    }

    public override void EnterState(StateMachine stateMachine)
    {
        
    }

    public override void ExitState(StateMachine stateMachine)
    {
        
    }
}
