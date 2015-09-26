using System;
using System.Collections.Generic;
using System.Linq;


class DropoutStudent : Student
{
    private string dropoutReason;

    public DropoutStudent(string firstName, string lastName, int age, int studentNumber, List<double> marks, string dropoutReason)
        : base(firstName, lastName, age, studentNumber, marks)
    {
        this.DropoutReason = dropoutReason;
    }

    public string DropoutReason
    {
        get { return this.dropoutReason; }
        set
        {
            this.dropoutReason = value;
        }
    }

    public void Reapply()
    {
        Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nStudent number: {3}\nAverage marks: {4}\nDropout reason: {5}", FirstName, LastName, Age, StudentNumber, AverageGrade, dropoutReason);
    }
}

