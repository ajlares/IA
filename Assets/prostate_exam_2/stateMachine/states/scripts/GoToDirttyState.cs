using UnityEngine;
using UnityEngine.AI;
[CreateAssetMenu(fileName = "GoToDirttyState", menuName = "Exam2/Slime/states/GoToDirttyState")]
public class GoToDirttyState : E2_BaseState
{
    public override void EnterState(E2_StateMachine stateMachine)
    {
        if (stateMachine.dirty.Count > 0)
        {
            int randombun = Random.Range(0, stateMachine.dirty.Count);
            stateMachine.Blackboard.Set("dirtyPos", stateMachine.dirty[randombun]);
        }
    }
    public override void Update(E2_StateMachine stateMachine)
    {
        if (stateMachine.dirty.Count > 0)
        {
            stateMachine.Blackboard.Get<NavMeshAgent>("agent").SetDestination( stateMachine.Blackboard.Get<GameObject>("dirtyPos").transform.position);
        }
    }
    public override void ExitState(E2_StateMachine stateMachine)
    {

    }
}