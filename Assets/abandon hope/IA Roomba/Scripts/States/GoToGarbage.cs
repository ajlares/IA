using UnityEngine;

[CreateAssetMenu(fileName = "GoToGarbage", menuName = "hope/Roomba/states/GoToGarbage")]
public class GoToGarbage : HopeBaseState
{
    public float GarbageDistanceMax = 2;
    public override void EnterState(HopeStateMachine stateMachine)
    {
        
    }
    public override void UpdateState(HopeStateMachine stateMachine)
    {
        if (stateMachine.Stats.garbageContainer != null)
        {
            float destination = Vector3.Distance(stateMachine.gameObject.transform.position, 
                stateMachine.Stats.garbageContainer.transform.position);
            if (GarbageDistanceMax > destination)
            {
                stateMachine.Stats.hasGarbage = false;
            }
            stateMachine.Stats.agent.SetDestination(stateMachine.Stats.garbageContainer.transform.position);
        }
    }
    public override void ExitState(HopeStateMachine stateMachine)
    {
        
    }
}
