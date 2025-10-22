using UnityEngine;

[CreateAssetMenu(fileName = "isCloseToTree", menuName = "hell/lumberjack/conditions/isCloseToTree")]
public class isCloseToTree : HellCondition
{
    public float maxDistance;
    public override bool CheckCondition(HellStateMachine stateMachine)
    {   
        GameObject tree = stateMachine.blackboard.Get<GameObject>("selectedTree");
        float distance = Vector3.Distance(tree.transform.position, stateMachine.gameObject.transform.position);
        if (distance < maxDistance)
        {
            return true;
        }
        return false;
    }
}
