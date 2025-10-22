using UnityEngine;
using UnityEngine.AI;
[CreateAssetMenu(fileName = "ConstrucPlace", menuName = "hell/constructor/states/ConstrucPlace")]
public class ConstrucPlace : HellBaseState
{
    public float navMeshRadius = 20;
    public override void EnterState(HellStateMachine stateMachine)
    {
        Vector3 direction = Vector3.zero;
        while (direction.magnitude != 0)
        {
            Vector3 randomDirection = Random.insideUnitSphere * navMeshRadius;
            randomDirection += stateMachine.gameObject.transform.position;
         
            NavMeshHit hit;
            if (NavMesh.SamplePosition(randomDirection, out hit, navMeshRadius, NavMesh.AllAreas))
            {
                direction = hit.position;
                stateMachine.blackboard.Set("moveDIr", direction);
            }
            Debug.Log(direction);
        }
    }
    
    public override void UpdateState(HellStateMachine stateMachine)
    {
        stateMachine.agent.SetDestination(stateMachine.blackboard.Get<Vector3>("moveDIr"));
    }

    public override void ExitState(HellStateMachine stateMachine)
    {
        
    }
}
