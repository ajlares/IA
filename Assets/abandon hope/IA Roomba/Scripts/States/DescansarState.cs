using UnityEngine;

[CreateAssetMenu(fileName = "DescansarState", menuName = "hope/Roomba/states/DescansarState")]
public class DescansarState : HopeBaseState
{
    public override void EnterState(HopeStateMachine stateMachine)
    {
        
    }
    public override void UpdateState(HopeStateMachine stateMachine)
    {
        stateMachine.gameObject.transform.Rotate(new Vector3(0,1,0));
    }
    public override void ExitState(HopeStateMachine stateMachine)
    {
        
    }
}