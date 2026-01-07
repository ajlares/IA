using System.Data;
using UnityEngine;

public class builder : MonoBehaviour
{
    public class Item
    {
        public string Name;
        public int Damage = 5;
        public bool IsMagic = false;
        public bool IsRare = false;

        public class Builder
        {
            private Item item;
            public Builder(string name)
            {
                item = new Item();
                item.Name = name;
            }
            public Builder withDamage(int Damage)
            {
                item.Damage = Damage;
                return this;
            }
            public Builder withMagicar( bool magic)
            {
                item.IsMagic = magic;
                return this;
            }
            public Builder withMakeRare( bool rarity)
            {
                item.IsRare = rarity;
                return this;
            }
            public Item Build()
            {
                return item;

            }
        }
    }

    public class Pet 
    {
        public string Name;
        public float Speed;
        public int Size;
        public bool isIn5;

         public class Builder
        {
            private Pet pet;
            public Builder(string name)
            {
                pet = new Pet();
                pet.Name = name;
            }
            public Builder changeSPeed(int speed)
            {
                pet.Speed = speed;
                return this;
            }
            public Builder changeSize( int size)
            {
                pet.Size = size;
                return this;
            }
            public Builder ChangeIsInt5( bool isIn5)
            {
                pet.isIn5 = isIn5;
                return this;
            }
            public Pet Build()
            {
                return pet;

            }
        }

    }

    public Item sword = new Item.Builder("Sword")
        .withDamage(5)
        .withMagicar(false)
        .withMakeRare(true)
        .Build();

    public Pet unicornio = new Pet.Builder("pancho")
        .ChangeIsInt5(false)
        .Build();
    
    Enemy cochiloko = EnemyFactory.Create(EnemyType.Zombie);

}
