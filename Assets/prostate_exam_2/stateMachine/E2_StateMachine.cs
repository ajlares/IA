using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class E2_StateMachine : MonoBehaviour
{
    public E2_BaseState initialState;
    public E2_BaseState currentState;
    [SerializeField] private GameObject house;
    [SerializeField] private NavMeshAgent agent; 
    public List<GameObject> dirty;
    public Blackboard Blackboard;

    private void Start()
    {
        Blackboard.Set("house",house);
        Blackboard.Set("cleaningTime", 10f);
        Blackboard.Set("agent", agent);
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
