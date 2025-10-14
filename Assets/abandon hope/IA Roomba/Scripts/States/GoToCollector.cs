using UnityEngine;

public class GoToCollector : HopeBaseState
{
    // profe si lee esto ayuda son las 2 am y no he avanzado nada:C
    private GameObject currentGarbage = null;
    private int randomGarbageIndex;
    public int garbagePickDistance = 2;
    public override void EnterState(HopeStateMachine stateMachine)
    {
        if (HopeManagers.Instance.garbageAmount > 0)
        { 
            randomGarbageIndex = Random.Range(0, HopeManagers.Instance.garbageAmount);
            currentGarbage = HopeManagers.Instance.GarbagesList[randomGarbageIndex];
        }
    }
    public override void UpdateState(HopeStateMachine stateMachine)
    {
        if (currentGarbage != null)
        {
            float distance = Vector3.Distance(currentGarbage.transform.position,
                stateMachine.gameObject.transform.position);
            if (garbagePickDistance > distance)
            {
                HopeManagers.Instance.RemoveGarbage(currentGarbage);
                stateMachine.Stats.hasGarbage = true;
            }
            else
            {
                stateMachine.Stats.agent.SetDestination(currentGarbage.transform.position);
            }
        }
        else
        {
            if (HopeManagers.Instance.garbageAmount > 0)
            { 
                randomGarbageIndex = Random.Range(0, HopeManagers.Instance.garbageAmount);
                currentGarbage = HopeManagers.Instance.GarbagesList[randomGarbageIndex];
            }
        }
    }
    public override void ExitState(HopeStateMachine stateMachine)
    {
        
    }
}
