using System;
using System.Collections.Generic;
using System.Linq;
class CurrentStudent : Student
{
    private string currentCourse;

    public CurrentStudent(string firstName, string lastName, int age, int studentNumber, List<double> marks, string currentCourse)
        : base(firstName, lastName, age, studentNumber, marks)
    {
        this.CurrentCourse = currentCourse;
    }
    public string CurrentCourse
    {
        get;
        set;
    }
}

