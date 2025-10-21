using System;
using UnityEngine;

public class HellStateMachine : MonoBehaviour
{
    [Header("states")] 
    public HellBaseState initialState;
    public HellBaseState currentState;

    private void Start()
    {
        ChangeState(initialState);
    }

    private void Update()
    {
        
    }

    public void ChangeState(HellBaseState newState)
    {
        currentState = newState;
    }
}
