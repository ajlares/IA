using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "NeedCOffe", menuName = "FSM/States/NeedCOffe.")]
public class NeedCOffe : State
{
    public float coffeAmount = 10;
    public float coffeTimeDelay = 1;
    public float indexTime = 0;
    public override void Update(StateMachine stateMachine)
    {
        if (coffeTimeDelay < indexTime)
        {
            stateMachine.coffeTime -= coffeAmount;
        }
        indexTime += Time.deltaTime;
    }

    public override void EnterState(StateMachine stateMachine)
    {
        indexTime = 0;
    }

    public override void ExitState(StateMachine stateMachine)
    {
        
    }
    
}
