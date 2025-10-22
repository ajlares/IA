using UnityEngine;

[CreateAssetMenu(fileName = "constructGoForWood", menuName = "hell/constructor/conditions/constructGoForWood")]
public class constructGoForWood : HellCondition
{
    public override bool CheckCondition(HellStateMachine stateMachine)
    {
        if (mapManager.Instance.woodAcount > 3)
        {
            return true;
        }
        return false;
    }
}
