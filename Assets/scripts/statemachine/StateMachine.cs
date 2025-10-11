using System;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public State initialState;
    public State curretState;
    public float coffeTime = 0;
    public bool coffetime = false;
    
    public void Start()
    {
        ChangeState(initialState);
    }

    private void Update()
    {
        if (curretState != null)
        {
            curretState.Update(this);
            curretState.CheckTransitions(this);
        }
        coffeTime += Time.deltaTime;
    }

    public void ChangeState(State newState)
    {
        if(curretState == newState || newState == null)
        {
            return;
        }
        if (curretState != null)
        {
            curretState.ExitState(this);
        }
        curretState = newState;
        curretState.EnterState(this);
    }
}
