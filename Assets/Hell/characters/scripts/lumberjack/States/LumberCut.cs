using UnityEngine;

[CreateAssetMenu(fileName = "LumberCut", menuName = "hell/lumberjack/states/LumberCut")]
public class LumberCut : HellBaseState
{
    public override void EnterState(HellStateMachine stateMachine)
    {
        stateMachine.blackboard.Set("cutTime", 0f);
    }
    
    public override void UpdateState(HellStateMachine stateMachine)
    {
        stateMachine.gameObject.transform.Rotate(new Vector3(0, 1, 0));
        float tempTime = stateMachine.blackboard.Get<float>("cutTime");
        tempTime += Time.deltaTime;
        stateMachine.blackboard.Set("cutTime", tempTime);
    }

    public override void ExitState(HellStateMachine stateMachine)
    {
        
    }
}