using UnityEngine;

[CreateAssetMenu(fileName = "finishConstruct", menuName = "hell/constructor/conditions/finishConstruct")]
public class finishConstruct : HellCondition
{
    public float constructTime = 0f;
    public override bool CheckCondition(HellStateMachine stateMachine)
    {
        if (stateMachine.blackboard.Get<float>("ConstructTime") > constructTime)
        {
            return true;
        }
        return false;
    }
}
