using System;
using System.Collections.Generic;
using System.Linq;

class Student : Person
{

    private int studentNumber;
    private double averageGrade;
    private List<double> marks;
    public Student(string firstName, string lastName, int age, int studentNumber, List<double> marks)
        : base(firstName, lastName, age)
    {
        this.Marks = marks;
        this.StudentNumber = studentNumber;
    }

    public int StudentNumber
    {
        get;
        set;
    }
    public double AverageGrade
    {
        get { return marks.Average(); }
    }
    public List<double> Marks
    {
        get { return this.marks; }
        set
        {
            if(value.Max() < 7 && value.Min() > 1)
            {
                this.marks = value;
            }
            else
            {
                throw new ArgumentException("Grades must be in range 2-6!");
            }
        }
    }
}

