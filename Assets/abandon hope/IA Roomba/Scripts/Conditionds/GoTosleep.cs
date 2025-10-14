using UnityEngine;

[CreateAssetMenu(fileName = "GoTosleep", menuName = "hope/Roomba/Condition/GoTosleep")]
public class GoTosleep : HopeCondition
{
    public override bool CheckCondition(HopeStateMachine stateMachine)
    {
        if (HopeManagers.Instance.garbageAmount == 0 && !stateMachine.Stats.hasGarbage)
        {
            return true;
        }
        return false;
    }
}