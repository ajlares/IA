using UnityEngine;

[CreateAssetMenu(fileName = "LumberDiscard", menuName = "hell/lumberjack/states/LumberDiscard")]
public class LumberDiscard : HellBaseState
{
    public override void EnterState(HellStateMachine stateMachine)
    {
        
    }
    
    public override void UpdateState(HellStateMachine stateMachine)
    {
        stateMachine.agent.SetDestination(stateMachine.WoodDepotGameObject.transform.position);
        
    }

    public override void ExitState(HellStateMachine stateMachine)
    {
        
    }
}
