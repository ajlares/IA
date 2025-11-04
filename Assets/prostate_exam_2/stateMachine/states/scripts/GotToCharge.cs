using UnityEngine;
using UnityEngine.AI;
[CreateAssetMenu(fileName = "GotToCharge", menuName = "Exam2/Slime/states/GotToCharge")]
public class GotToCharge : E2_BaseState
{
    public override void EnterState(E2_StateMachine stateMachine)
    {
        
    }

    public override void Update(E2_StateMachine stateMachine)
    {
        stateMachine.Blackboard.Get<NavMeshAgent>("agent").SetDestination( stateMachine.Blackboard.Get<GameObject>("house").transform.position);
    }
    public override void ExitState(E2_StateMachine stateMachine)
    {
        
    }
}
