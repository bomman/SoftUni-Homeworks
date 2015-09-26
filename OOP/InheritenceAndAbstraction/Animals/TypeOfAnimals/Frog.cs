using System;
using Animals.Enumarator;

namespace Animals.TypeOfAnimals
{
    class Frog : Animal
    {
        public Frog(string name, short age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Croak");
        }
    }
}
