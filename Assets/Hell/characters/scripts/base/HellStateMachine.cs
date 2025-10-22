using System;
using UnityEngine;
using UnityEngine.AI;

public class HellStateMachine : MonoBehaviour
{
    [Header("states")] 
    public HellBaseState initialState;
    public HellBaseState currentState;
    public Blackboard blackboard = new Blackboard();
    public NavMeshAgent agent;
    public GameObject CabinGameObject;
    public GameObject WoodDepotGameObject;
    private void Start()
    {
        ChangeState(initialState);
        blackboard.Set("hasWood", false);
        blackboard.Set("woodAcount", 0f);
    }

    private void Update()
    {
        currentState.UpdateState(this);
        currentState.CheckTransitions(this);
    }

    public void ChangeState(HellBaseState newState)
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
        Debug.Log("ChancheState");
    }
}
