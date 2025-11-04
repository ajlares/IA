using UnityEngine;

[CreateAssetMenu(fileName = "StayInIdle", menuName = "Exam2/Slime/Conditionds/StayInIdle")]
public class StayInIdle : E2_BaseCondition
{
    public float maxCharge;
    public override bool Check(E2_StateMachine stateMachine)
    {
        if (stateMachine.Blackboard.Get<float>("chargingamount") > maxCharge)
        {
            return true;
        }
        return false;
    }
}
