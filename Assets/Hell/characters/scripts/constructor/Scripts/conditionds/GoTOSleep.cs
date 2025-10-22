using UnityEngine;
[CreateAssetMenu(fileName = "GoTOSleep", menuName = "hell/constructor/conditions/GoTOSleep")]
public class GoTOSleep : HellCondition
{
    public override bool CheckCondition(HellStateMachine stateMachine)
    {   
        if (mapManager.Instance.woodAcount < 3)
        {
            return true;
        }
        return false;
    }
}
