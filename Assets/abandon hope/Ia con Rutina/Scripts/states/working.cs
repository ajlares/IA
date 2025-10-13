using UnityEngine;
[CreateAssetMenu(fileName = "working", menuName = "hope/Routine/states/working")]
public class working : HopeBaseState
{
    private GameObject CurrentPoint;
    public override void EnterState(HopeStateMachine stateMachine)
    {
        
    }
    public override void UpdateState(HopeStateMachine stateMachine)
    {
        if (stateMachine.Stats.workWaipoint.Count > 0)
        {
            int random = Random.Range(0, stateMachine.Stats.workWaipoint.Count);
            if (CurrentPoint == null)
            {
                CurrentPoint = stateMachine.Stats.workWaipoint[random];
            }
            else
            {
                if (1 > Vector3.Distance(stateMachine.gameObject.transform.position, CurrentPoint.transform.position))
                {
                    CurrentPoint = stateMachine.Stats.workWaipoint[random];
                }
            }
            stateMachine.Stats.agent.SetDestination(CurrentPoint.transform.position);
        }
    }
    public override void ExitState(HopeStateMachine stateMachine)
    {
        
    }
}