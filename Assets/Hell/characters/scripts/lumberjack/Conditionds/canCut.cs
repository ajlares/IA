using UnityEngine;

[CreateAssetMenu(fileName = "canCut", menuName = "hell/lumberjack/conditions/canCut")]
public class canCut : HellCondition
{
    public override bool CheckCondition(HellStateMachine stateMachine)
    {   
        bool condition = stateMachine.blackboard.Get<bool>("hasWood");
        Debug.Log(condition);
        if (!condition && mapManager.Instance.Trees.Count > 0)
        {
            return true;
        }
        return false;
    }
}