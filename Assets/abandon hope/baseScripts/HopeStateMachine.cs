using System;
using UnityEngine;

public class HopeStateMachine : MonoBehaviour
{
    [Header("state machine basics")]
    public HopeBaseState initialState;
    public HopeBaseState currentState;

    [Header("IA other Components")] 
    public HopeStats Stats;

    private void Start()
    {
        ChangeState(initialState);
    }

    private void Update()
    {
        if (currentState != null)
        {
            currentState.UpdateState(this);
            currentState.CheckTransitions(this);
        }
    }
    public void ChangeState(HopeBaseState newState)
    {
        if(currentState == newState || newState == null)
        {
            return;
        }
        if (currentState != null)
        { 
            currentState.ExitState(this);
        }
        currentState = newState;
        currentState.EnterState(this);
    }
}