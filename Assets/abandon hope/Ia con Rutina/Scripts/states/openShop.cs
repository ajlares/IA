using UnityEngine;

[CreateAssetMenu(fileName = "openshop", menuName = "hope/Routine/states/openshop")]
public class openShop : HopeBaseState
{
    public override void EnterState(HopeStateMachine stateMachine)
    {
        
    }

    public override void UpdateState(HopeStateMachine stateMachine)
    {
        Vector3 destination = stateMachine.Stats.ShopGameObject.transform.position;
        stateMachine.Stats.agent.SetDestination(destination);
    }

    public override void ExitState(HopeStateMachine stateMachine)
    {
        
    }
}
