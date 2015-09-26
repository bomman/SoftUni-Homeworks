using System;
using System.Reflection.Emit;
using Animals.Enumarator;
using Animals.Interfaces;

namespace Animals.TypeOfAnimals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private short age;
        private Gender gender;

        protected Animal(string name, short age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name", "The name cannot be empty space or null!");
                }
                this.name = value;
            }
        }

        public short Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age", "Age cannot be a negative number");
                }
                this.age = value;
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set
            {
                if (value != Enumarator.Gender.Female && value != Enumarator.Gender.Male)
                {
                    throw new ArgumentException("Gender", "The gender can be only Male and Female!");
                }
               
                    this.gender = value;
                
            }
        }

        public abstract void ProduceSound();

    }
}