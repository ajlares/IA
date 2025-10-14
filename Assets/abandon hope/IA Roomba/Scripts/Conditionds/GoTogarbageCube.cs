using UnityEngine;

[CreateAssetMenu(fileName = "GoTogarbageCube", menuName = "hope/Roomba/Condition/GoTogarbageCube")]
public class GoTogarbageCube : HopeCondition
{
    public override bool CheckCondition(HopeStateMachine stateMachine)
    {
        return stateMachine.Stats.hasGarbage;
    }
}
