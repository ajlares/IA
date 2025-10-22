using UnityEngine;
[CreateAssetMenu(fileName = "startConstruct", menuName = "hell/constructor/conditions/startConstruct")]
public class startConstruct : HellCondition
{
    public float maxDistance;
    public override bool CheckCondition(HellStateMachine stateMachine)
    {
        float distance = Vector3.Distance(stateMachine.gameObject.transform.position,
            stateMachine.blackboard.Get<Vector3>("moveDir"));
        if (distance > maxDistance)
        {
            return true;
        }
        return false;
    }
}
