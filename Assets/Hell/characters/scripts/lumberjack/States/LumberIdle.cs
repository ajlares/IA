using UnityEngine;

[CreateAssetMenu(fileName = "LumberIdle", menuName = "hell/lumberjack/states/LumberIdle")]
public class LumberIdle : HellBaseState
{
    public override void EnterState(HellStateMachine stateMachine)
    {
        
    }
    
    public override void UpdateState(HellStateMachine stateMachine)
    {
        stateMachine.gameObject.transform.Rotate(new Vector3(0, 1, 0));
    }

    public override void ExitState(HellStateMachine stateMachine)
    {
        
    }
}