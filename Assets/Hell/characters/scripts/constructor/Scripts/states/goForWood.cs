using UnityEngine;
[CreateAssetMenu(fileName = "goForWood", menuName = "hell/constructor/states/goForWood")]
public class goForWood : HellBaseState
{
    public override void EnterState(HellStateMachine stateMachine)
    {

    }
    
    public override void UpdateState(HellStateMachine stateMachine)
    {
        stateMachine.agent.SetDestination(stateMachine.WoodDepotGameObject.transform.position);       
    }

    public override void ExitState(HellStateMachine stateMachine)
    {
        mapManager.Instance.woodAcount -= 3;
    }
}
