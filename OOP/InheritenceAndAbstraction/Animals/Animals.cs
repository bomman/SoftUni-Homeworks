using System.Collections.Generic;
using System.Linq;
using Animals.Enumarator;
using Animals.TypeOfAnimals;
using Animals.TypeOfAnimals.Cats;

namespace Animals
{
    class Animals
    {
        static List<Animal> AllAnimals()
        {
            List<Animal> animals = new List<Animal>()
            {
                new Dog("Sharo", 3, Gender.Female),
                new Dog("Rik", 5, Gender.Male),
                new Dog("Luchiq", 2, Gender.Female),
                new Frog("Princ", 8, Gender.Male),
                new Frog("Princess", 5, Gender.Female),
                new Frog("Jaba",2, Gender.Male),
                new Kitten("Kittie", 5),
                new Kitten("Jensko Kote", 1),
                new Tomcat("Tom", 7),
                new Tomcat("Mujko Kote", 4)
            };
            return animals;
        }
        static void Main()
        {
            List<Animal> animals = AllAnimals();

            double averageAgeOfDogsInList = animals
                .Where(animal => animal is Dog)
                .Average(dogs => dogs.Age);

            double averageAgeOfFrogsInList = animals
                .Where(animal => animal is Frog)
                .Average(frogs => frogs.Age);

            double averageAgeOfCatsInList = animals
                .Where(animal => animal is Cat)
                .Average(cats => cats.Age);

           



        }
    }
}
