using UnityEngine;

[CreateAssetMenu(fileName = "finishClean", menuName = "Exam2/Slime/Conditionds/finishClean")]
public class finishClean : E2_BaseCondition
{
    public int maxCLeaningTime = 0;
    public override bool Check(E2_StateMachine stateMachine)
    {
        if (stateMachine.Blackboard.Get<float>("cleaningIndexTime") > maxCLeaningTime)
        {
            return true;
        }
        return false;
    }
}
