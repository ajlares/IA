using UnityEngine;

[CreateAssetMenu(fileName = "TimeCondition", menuName = "hope/Routine/conditions/timeCondition")]
public class TimeCondition : HopeCondition
{
    public float daytime = 0;
    public float nighttime = 0;
    public override bool CheckCondition(HopeStateMachine stateMachine)
    {
        if (daytime <= HopeManagers.Instance.currentTime && nighttime>=HopeManagers.Instance.currentTime)
        {
            return true;
        }
        return false;
    }
}