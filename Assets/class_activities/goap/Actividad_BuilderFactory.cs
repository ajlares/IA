using System;
using UnityEngine;

public class Actividad_BuilderFactory : MonoBehaviour
{
     public class Pet 
    {
        public string Name;
        public int Size;
        public Color color;

         public class Builder
        {
            private Pet pet;
            public Builder(string name)
            {
                pet = new Pet();
                pet.Name = name;
            }
            public Builder changeSize( int size)
            {
                pet.Size = size;
                return this;
            }
            public Builder Color( Color newColor)
            {
                pet.color = newColor;
                return this;
            }
            public Pet Build()
            {
                return pet;
            }
        }
    }

    public enum dogType
    {
        Lux,
        Ammy
    }

    public static class EnemyFactory
    {
        public static Pet Create(dogType type)
        {
            switch(type)
            {
                case dogType.Lux:
                    return new Pet.Builder("Lux")
                    .changeSize(4)
                    .Color(Color.white)
                    .Build();
                case dogType.Ammy:
                    return new Pet.Builder("Ammy")
                    .changeSize(5)
                    .Color(Color.beige)
                    .Build();
                default:
                    Debug.Log("ta muelto");
                    return null;
            }
        }
    }

}
