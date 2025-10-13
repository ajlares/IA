using UnityEngine;

[CreateAssetMenu(fileName = "closeShoop", menuName = "hope/Routine/states/closeShoop")]
public class closeShoop : HopeBaseState
{
    public override void EnterState(HopeStateMachine stateMachine)
    {
        
    }

    public override void UpdateState(HopeStateMachine stateMachine)
    {
        Vector3 destination = stateMachine.Stats.HaouseGameObject.transform.position;
        stateMachine.Stats.agent.SetDestination(destination);
    }

    public override void ExitState(HopeStateMachine stateMachine)
    {
        
    }
}
