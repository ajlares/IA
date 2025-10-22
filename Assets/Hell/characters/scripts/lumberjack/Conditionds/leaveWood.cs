using UnityEngine;

[CreateAssetMenu(fileName = "leaveWood", menuName = "hell/lumberjack/conditions/leaveWood")]
public class leaveWood : HellCondition
{
    public float maxDistance;
    public override bool CheckCondition(HellStateMachine stateMachine)
    {   
        GameObject depot = stateMachine.WoodDepotGameObject;
        float distance = Vector3.Distance(depot.transform.position, stateMachine.gameObject.transform.position);
        if (distance < maxDistance)
        {
            mapManager.Instance.woodAcount++;
            return true;
        }
        return false;
    }
}
