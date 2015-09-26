using System;
using System.Collections.Generic;
using System.Linq;

class OnlineStudent : CurrentStudent
{
    public OnlineStudent(string firstName, string lastName, int age, int studentNumber, List<double> marks, string currentCourse)
        : base(firstName, lastName, age, studentNumber, marks, currentCourse)
    {

    }
}

