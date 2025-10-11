using UnityEngine;
[CreateAssetMenu(fileName = "DrinkCoffe", menuName = "FSM/Conditions/DrinkCoffe")]
public class DrinkCoffe : Condicion
{
    public float timeToCoffe;
    public override bool Check(StateMachine stateMachine)
    {
        if (stateMachine.coffeTime > timeToCoffe)
        {
            
            return true;
        }
        return false;
    }
}