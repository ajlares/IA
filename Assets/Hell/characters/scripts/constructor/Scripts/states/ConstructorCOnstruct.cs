using UnityEngine;
[CreateAssetMenu(fileName = "ConstructorCOnstruct", menuName = "hell/constructor/states/ConstructorCOnstruct")]
public class ConstructorCOnstruct : HellBaseState
{
    public override void EnterState(HellStateMachine stateMachine)
    {
        stateMachine.blackboard.Set("ConstructTime" , 0f);
    }
    public override void UpdateState(HellStateMachine stateMachine)
    {
        float time = stateMachine.blackboard.Get<float>("ConstructTime");
        time += Time.deltaTime;
        stateMachine.blackboard.Set("ConstructTime", time);
        stateMachine.gameObject.transform.Rotate(new Vector3(0, 1, 0));
    }
    public override void ExitState(HellStateMachine stateMachine)
    {
        Instantiate(stateMachine.housePrefab, stateMachine.gameObject.transform.position, stateMachine.gameObject.transform.rotation);
    }
}
