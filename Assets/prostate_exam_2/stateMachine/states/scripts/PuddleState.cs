using UnityEngine;

[CreateAssetMenu(fileName = "PuddleState", menuName = "Exam2/Slime/states/PuddleState")]
public class PuddleState : E2_BaseState
{
    public override void EnterState(E2_StateMachine stateMachine)
    {
        stateMachine.Blackboard.Set("chargingamount", 0f);
    }

    public override void Update(E2_StateMachine stateMachine)
    {
        stateMachine.gameObject.transform.Rotate(new Vector3(0, 1, 0));
        float indexTime = stateMachine.Blackboard.Get<float>("chargingamount") + Time.deltaTime;
        stateMachine.Blackboard.Set("chargingamount", indexTime);
    }

    public override void ExitState(E2_StateMachine stateMachine)
    {
        
    }
}
