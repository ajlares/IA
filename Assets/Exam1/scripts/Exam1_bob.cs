using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Exam1_bob : MonoBehaviour
{
    // my spa
    [Header("finish")]
    private GameObject door;
    private GameObject doorButton;
    public GameObject finishGameObject;
    
    [Header("movement")]
    private NavMeshAgent agent;
    private Vector3 movePosition;
    private CharacterController CC;

    [Header("actions")]
    public bool isActing;

    [Header("vision")] 
    public float viewRadius = 10f;
    [Range(0, 360)] public float viewAngle = 90 ;
    public GameObject visiionPoint;
    public LayerMask targetsMask;
    public LayerMask obstaclesMask;
    
    [Header("dictionary")]
    private Dictionary<string, float> acctionScores;
    

    private void Start()
    {
        // pickup nav mesh and character component
        gameObject.TryGetComponent(out agent);
        gameObject.TryGetComponent(out CC);
        // settup dictionary
        acctionScores = new Dictionary<string, float>()
        {
            {"finish",0f},
            {"button",0f},
            {"randomPoint",0f}
        } ;
    }

    private void Update()
    {
        //sens
        Collider[] targetsInViewRadius = Physics.OverlapSphere(transform.position, viewRadius, targetsMask);

        foreach (Collider target in targetsInViewRadius)
        {
            Vector3 dirToTarget = (target.transform.position - transform.position).normalized;
            float angleToTarget = Vector3.Angle(transform.forward, dirToTarget);

            if (angleToTarget < viewAngle / 2)
            {
                float distToTarget = Vector3.Distance(transform.position, target.transform.position);

                if (!Physics.Raycast(transform.position, dirToTarget, distToTarget, obstaclesMask))
                {
                    if (target.gameObject.CompareTag("button") && doorButton == null)
                    {
                        Debug.Log("saveButton");
                        doorButton = target.gameObject;
                    }                   
                    if (target.gameObject.CompareTag("door") && door == null)
                    {
                        Debug.Log("saveDoor");
                        door = target.gameObject;
                    }
                }
            }
        }
        //act
        
        //plan
        
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
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, viewRadius);

        Vector3 leftBoundary = DirFromAngle(-viewAngle / 2);
        Vector3 rightBoundary = DirFromAngle(viewAngle / 2);

        Gizmos.color = Color.blue;
        Gizmos.DrawLine(transform.position, transform.position + leftBoundary * viewRadius);
        Gizmos.DrawLine(transform.position, transform.position + rightBoundary * viewRadius);
    }

    Vector3 DirFromAngle(float angleInDegrees)
    {
        angleInDegrees += transform.eulerAngles.y;
        return new Vector3(Mathf.Sin(angleInDegrees * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegrees * Mathf.Deg2Rad));
    }

}
