using UnityEngine;

[CreateAssetMenu(fileName = "goTOcharche", menuName = "Exam2/Slime/Conditionds/goTOcharche")]
public class goTOcharche : E2_BaseCondition
{
    public int maxDistance;
    public override bool Check(E2_StateMachine stateMachine)
    {
        float Distance = Vector3.Distance(stateMachine.Blackboard.Get<GameObject>("house").transform.position,stateMachine.transform.position);
        if (Distance < maxDistance)
        {
            return true;
        }
        return false;
    }
}
