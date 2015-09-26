using System;
using Animals.Enumarator;

namespace Animals.TypeOfAnimals
{
    class Dog : Animal
    {
        public Dog(string name, short age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
