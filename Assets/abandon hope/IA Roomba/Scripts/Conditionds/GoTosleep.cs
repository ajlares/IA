using UnityEngine;

[CreateAssetMenu(fileName = "GoTosleep", menuName = "hope/Roomba/Condition/GoTosleep")]
public class GoTosleep : HopeCondition
{
    public override bool CheckCondition(HopeStateMachine stateMachine)
    {
        return false;
    }
}