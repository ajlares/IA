using UnityEngine;
[CreateAssetMenu(fileName = "hasWood", menuName = "hell/constructor/conditions/hasWood")]
public class hasWood : HellCondition
{
    public float maxDistance;
    public override bool CheckCondition(HellStateMachine stateMachine)
    {   
        float distance = Vector3.Distance(stateMachine.gameObject.transform.position,stateMachine.WoodDepotGameObject.transform.position);
        if (distance < maxDistance)
        {
            return true;
        }
        return false;
    }
}
