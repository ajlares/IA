using UnityEngine;

[CreateAssetMenu(fileName = "TimeCondition", menuName = "hope/Routine/conditions/timeCondition")]
public class TimeCondition : HopeCondition
{
    public float daytime = 0;
    public override bool CheckCondition(HopeStateMachine stateMachine)
    {
        if (daytime <= HopeManagers.Instance.currentTime)
        {
            Debug.Log("change");
            return true;
        }
        return false;
    }
}