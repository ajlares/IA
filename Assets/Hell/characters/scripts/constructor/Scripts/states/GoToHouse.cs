using UnityEngine;
[CreateAssetMenu(fileName = "GoToHouse", menuName = "hell/constructor/states/GoToHouse")]
public class GoToHouse : HellBaseState
{
    public override void EnterState(HellStateMachine stateMachine)
    {

    }
    
    public override void UpdateState(HellStateMachine stateMachine)
    {
        stateMachine.agent.SetDestination(stateMachine.CabinGameObject.transform.position);
    }

    public override void ExitState(HellStateMachine stateMachine)
    {
        
    }
}
