using UnityEngine;

public class factory : MonoBehaviour
{

}

    public abstract class Enemy
    {
        public int Health;

        public abstract void Attack();
    }

    public class Zombie : Enemy
    {
        public Zombie()
        {
            Health = 50;
        }

        public override void Attack()
        {
            Debug.Log("zombie bite");
        }
    }
    public class Skeleton : Enemy
    {
        public Skeleton()
        {
            Health = int.MaxValue;
        }

        public override void Attack()
        {
            Debug.Log("Skeleton punch");
        }
    }

    public enum EnemyType
    {
        Zombie,
        Skeleton
    }

    public static class EnemyFactory
    {
        public static Enemy Create(EnemyType type)
        {
            switch(type)
            {
                case EnemyType.Zombie:
                    return new Zombie();
                case EnemyType.Skeleton:
                    return new Skeleton();
                default:
                    Debug.Log("ta peldido");
                    return null;
            }
        }
    }