using UnityEngine;

[CreateAssetMenu(fileName = "Cleaning", menuName = "Exam2/Slime/states/Cleaning")]
public class Cleaning : E2_BaseState
{
    public override void EnterState(E2_StateMachine stateMachine)
    {
        stateMachine.Blackboard.Set("cleaningIndexTime", 0f);
    }

    public override void Update(E2_StateMachine stateMachine)
    {
        stateMachine.gameObject.transform.Rotate(new Vector3(0, 1, 0));
        float indexTime = stateMachine.Blackboard.Get<float>("cleaningIndexTime") + Time.deltaTime;
        stateMachine.Blackboard.Set("cleaningIndexTime", indexTime);
    }

    public override void ExitState(E2_StateMachine stateMachine)
    {
        
    }
}