using UnityEngine;

[CreateAssetMenu(fileName = "Condition", menuName = "FSM/Conditions/Condition")]
public class IsOnGround : Condicion
{
    public float checkDistance = 1.5f;
    public LayerMask layerMask;
    public override bool Check(StateMachine stateMachine)
    {
        Ray ray = new Ray(stateMachine.transform.position, Vector3.down);
        return Physics.Raycast(ray, checkDistance, layerMask);
    }
}
