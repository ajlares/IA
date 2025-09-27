using System;
using UnityEngine;
using UnityEngine.AI;

public class Exam1_bob : MonoBehaviour
{
    // my spa
    [Header("finish")]
    private door door;
    private doorButton doorButton;
    public GameObject finishGameObject;
    
    [Header("movement")]
    private NavMeshAgent agent;
    private Vector3 movePosition;
    private CharacterController CC;

    private void Start()
    {
        // pickup nav mesh and character component
        gameObject.TryGetComponent(out agent);
        gameObject.TryGetComponent(out CC);
    }

    private void move(Vector3 movepos)
    {
        
    }

    private void PressButton()
    {
        
    }

    private void Finish()
    {
        CC.Move(finishGameObject.transform.position);
    }
}
