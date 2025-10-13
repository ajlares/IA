using UnityEngine;

[CreateAssetMenu(fileName = "itsInPlace", menuName = "hope/Routine/conditions/itsInPlace")]
public class itsInPlace : HopeCondition
{
    public float distanceMax;
    public override bool CheckCondition(HopeStateMachine stateMachine)
    {
        float distance = Vector3.Distance(stateMachine.Stats.ShopGameObject.transform.position, stateMachine.transform.position);
        if (distance < distanceMax)
        {
            return true;
        }
        return false;
    }
}