using UnityEngine;

[CreateAssetMenu(fileName = "LumberGoTo", menuName = "hell/lumberjack/states/LumberGoTo")]
public class LumberGoTo : HellBaseState
{
    public override void EnterState(HellStateMachine stateMachine)
    {
        if (mapManager.Instance.Trees.Count > 0)
        {
            int randomTree = Random.Range(0, mapManager.Instance.Trees.Count);
            GameObject tempTree = mapManager.Instance.Trees[randomTree];
            
            stateMachine.blackboard.Set("selectedTree", tempTree);
        }
    }
    
    public override void UpdateState(HellStateMachine stateMachine)
    {
        if (stateMachine.blackboard.Get<GameObject>("selectedTree") != null)
        {
            stateMachine.agent.SetDestination(stateMachine.blackboard.Get<GameObject>("selectedTree").transform.position);
        }
    }

    public override void ExitState(HellStateMachine stateMachine)
    {
        
    }
}
