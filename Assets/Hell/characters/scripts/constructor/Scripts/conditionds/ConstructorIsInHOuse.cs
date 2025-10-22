using UnityEngine;

[CreateAssetMenu(fileName = "ConstructorIsInHOuse", menuName = "hell/constructor/conditions/ConstructorIsInHOuse")]
public class ConstructorIsInHOuse : HellCondition
{
    public float maxDistance = 0;
    public override bool CheckCondition(HellStateMachine stateMachine)
    {
        float distance = Vector3.Distance(stateMachine.CabinGameObject.transform.position, stateMachine.gameObject.transform.position);
        if (distance > maxDistance)
        {
            return true;
        }
        return false;
    }
}
