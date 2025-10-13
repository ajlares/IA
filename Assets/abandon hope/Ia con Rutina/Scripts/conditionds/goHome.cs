using UnityEngine;

[CreateAssetMenu(fileName = "goHome", menuName = "hope/Routine/conditions/goHome")]
public class goHome : HopeCondition
{
    public float distanceMax;
    public override bool CheckCondition(HopeStateMachine stateMachine)
    {
        float distance = Vector3.Distance(stateMachine.Stats.HaouseGameObject.transform.position, stateMachine.transform.position);
        if (distance < distanceMax)
        {
            return true;
        }
        return false;
    }
}