using UnityEngine;

[CreateAssetMenu(fileName = "GoToClean", menuName = "Exam2/Slime/Conditionds/GoToClean")]
public class GoToClean : E2_BaseCondition
{
    public int maxDistance;
    public override bool Check(E2_StateMachine stateMachine)
    {
        float Distance = Vector3.Distance(stateMachine.Blackboard.Get<GameObject>("dirtyPos").transform.position,stateMachine.transform.position);
        if (Distance < maxDistance)
        {
            return true;
        }
        return false;
    }
}
