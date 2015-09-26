using System;
using Animals.Enumarator;

namespace Animals.TypeOfAnimals.Cats
{
    abstract class Cat : Animal
    {
        protected Cat(string name, short age, Gender gender) : base(name, age, gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }

     
    }
}
