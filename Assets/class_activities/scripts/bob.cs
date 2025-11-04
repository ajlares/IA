using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class bob : MonoBehaviour
{
    private float health = 50;
    private int maxHealth = 50;
    
    public GameObject player;
    
    public Transform [] patrolPoints = new Transform[4];
    
    public int patrolPointIndex = 0;
    public float distanceCheck = 1;
    public float fleeDistance;
    private float distanceToPlayer;

    private bool los = false;

    private Dictionary<string, float> acctionScores;

    public NavMeshAgent agent;

    public TextMeshProUGUI fleeText;
    public TextMeshProUGUI chaseText;

    public float criticalHealth = 0.3f;

    public float viewDistanc = 5;
    public float viewAngle = 45;
    
    private void Start()
    {
        acctionScores = new Dictionary<string, float>()
        {
            {"flee",0f},
            {"chase",0f},
            {"patrol",0f}
        } ;
    }

    private void Update()
    {
        //sense
        distanceToPlayer = Vector3.Distance(gameObject.transform.position, player.transform.position);

        los = PlayerInFov();
        
        if (Vector3.Distance(gameObject.transform.position, patrolPoints[patrolPointIndex].transform.position) <
            distanceCheck)
        {
            patrolPointIndex = (patrolPointIndex + 1) % patrolPoints.Length;
        }

        //plan
        float healthRatio = Mathf.Clamp01(health / maxHealth);
        float disanceRatio = Mathf.Clamp01(distanceToPlayer / fleeDistance);

        if (healthRatio < criticalHealth)
        {
            distanceToPlayer = 0;
            
        }
        float riskFactor = (1 - healthRatio) * (1 - disanceRatio);
        float aggroFacor = healthRatio * disanceRatio;
        float total = riskFactor + aggroFacor;
        aggroFacor += healthRatio > criticalHealth ? 1 : 0;
        
        riskFactor /= total;
        aggroFacor /= total;
        
        acctionScores["flee"] = riskFactor * 10 * (los == true ? 1 : 0);
        acctionScores["chase"] = aggroFacor * 10 * (los == true ? 1 : 0);
        acctionScores["patrol"] = 3f;
        
        fleeText.text = "Flee" + acctionScores["flee"];
        chaseText.text = "Chase" + acctionScores["chase"];
        
        //act
        string chosenAction = acctionScores.Aggregate((l,r) => l.Value > r.Value ? l : r).Key;

        switch (chosenAction)
        {
            case "flee":
                flee();
                break;
            
            case "chase":
                chase();
                break;
            
            case "patrol":
                patrol();
                break;
            
            default:
                break;
        }
    }
    private void flee()
    {
        Vector3 fleeDirection = transform.position + (transform.position - player.transform.position).normalized;
        agent.SetDestination(new Vector3(fleeDirection.x, 0, fleeDirection.z));
    }

    private void chase()
    {
        agent.SetDestination(player.transform.position);
    }
    private void patrol()
    {
        agent.SetDestination(patrolPoints[patrolPointIndex].transform.position);
    }

    private bool PlayerInFov()
    {
        Vector3 dirToPlayer = (player.transform.position - transform.position).normalized;
        if (distanceToPlayer > viewDistanc)
        {
            return false;
        }
        float angle  = Vector3.Angle(transform.forward, dirToPlayer);
        if (distanceToPlayer > viewDistanc / 2)
        {
            return false;
        }

        if (Physics.Raycast(transform.position,  dirToPlayer, out RaycastHit hit, distanceToPlayer))
        {
            if (hit.collider.gameObject.TryGetComponent(out PlayerMovement _))
            {
                return true;
            }
            return false;
        }
        return false;
    }
    public void minhealth()
    {
        health -= 5;
        if (health <= 0)
        {
            health = 0.1f;
        }
        Debug.Log(health);
    }    
    public void maxhealth()
    {
        health += 5;
        Debug.Log(health);
    }
    
}

