using System;

class Trainer : Person
{
    public Trainer(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        
    }

    public void Courses(string course)
    {
        Console.WriteLine("The course has been created:{0}", course);
    }
}

