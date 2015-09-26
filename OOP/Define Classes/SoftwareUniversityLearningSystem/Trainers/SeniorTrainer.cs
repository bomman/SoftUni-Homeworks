using System;

class SeniorTrainer : Trainer
{
    public SeniorTrainer(string firstName, string lastName,int age):base(firstName, lastName, age)
    {

    }
    public void DeleteCourse(string course)
    {
       Console.WriteLine("The course has been deleted: {0}", course);
    }
}

