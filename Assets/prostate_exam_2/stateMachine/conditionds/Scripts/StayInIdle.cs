using UnityEngine;

public class StayInIdle : E2_BaseCondition
{
    public override bool Check(E2_StateMachine stateMachine)
    {
        return false;
    }
}
