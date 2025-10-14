using UnityEngine;

[CreateAssetMenu(fileName = "GoToCollec", menuName = "hope/Roomba/Condition/GoToCollec")]
public class GoToCollec : HopeCondition
{
    public override bool CheckCondition(HopeStateMachine stateMachine)
    {
        if (HopeManagers.Instance.garbageAmount > 0 && !stateMachine.Stats.hasGarbage)
        {
            return true;
        }
        return false;
    }
}