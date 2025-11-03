using System.Collections.Generic;
using UnityEngine;

public class E2_StateMachine : MonoBehaviour
{
    public E2_BaseState initialState;
    public E2_BaseState currentState;
    public GameObject house;
    public List<GameObject> dirty;

    private void Start()
    {
        
    }
    private void Update()
    {
        if (currentState != null)
        {
            currentState.Update(this);
            currentState.CheckTransitions(this);
        }
    }
    
    public void ChangeState(E2_BaseState newState)
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
