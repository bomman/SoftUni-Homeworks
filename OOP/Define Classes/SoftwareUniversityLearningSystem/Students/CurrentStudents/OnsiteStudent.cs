using System;
using System.Collections.Generic;
using System.Linq;

class OnsiteStudent : CurrentStudent
{
    private int numberOfVisits;
    public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, List<double> marks, string currentCourse, int numberOfVisits)
        : base(firstName, lastName, age, studentNumber, marks, currentCourse)
    {
        this.NumberOfVisits = numberOfVisits;
    }

    public int NumberOfVisits
    {
        get;
        set;
    }
}

