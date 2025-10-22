using UnityEngine;

[CreateAssetMenu(fileName = "stopCut", menuName = "hell/lumberjack/conditions/stopCut")]
public class stopCut : HellCondition
{
    public float cuttingTimee= 0;
    public override bool CheckCondition(HellStateMachine stateMachine)
    {
        if (stateMachine.blackboard.Get<float>("cutTime") > cuttingTimee)
        {
            return true;
        }
        return false;
    }
}
