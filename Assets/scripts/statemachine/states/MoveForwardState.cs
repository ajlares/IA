using UnityEngine;

[CreateAssetMenu(fileName = "statePatito", menuName = "FSM/States/StatePatito")]
public class MoveForwardState : State
{
    public float speed = 2f;
    
    public override void EnterState(StateMachine stateMachine)
    {

    }

    public override void ExitState(StateMachine stateMachine)
    {

    }  
    public override void Update(StateMachine stateMachine)
    {
        stateMachine.gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
    }
    
}
