using UnityEngine;

[CreateAssetMenu(fileName = "GoToCollec", menuName = "hope/Roomba/Condition/GoToCollec")]
public class GoToCollec : HopeCondition
{
    public override bool CheckCondition(HopeStateMachine stateMachine)
    {
        return false;
    }
}