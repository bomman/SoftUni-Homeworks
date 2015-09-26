using System;
using System.Collections.Generic;
using System.Linq;

class SoftwareUniversityLearningSystemTest
{
    static void Main()
    {
        List<Object> test = new List<Object>() 
    {
        new Person("Petar", "Minchev", 24),
        new Student("Simeon", "Vanov", 22, 24122, new List<double>(){4, 2,5 ,6}),
        new Student("Ivan", "Milenkov", 20, 21424, 
            new List<double>() { 5, 3, 2.5, 5, 6 }), 
            new CurrentStudent("Diana", "Vasileva", 21, 2421, 
                new List<double>() { 6, 6, 6, 6, 5 }, "Obektno programirane"), 
                new OnsiteStudent("Simeon", "Mechkarov", 20, 1251, 
                    new List<double>() { 5, 2, 5, 2, 5, 4 }, "Obektno programirane", 25), 
                    new OnlineStudent("Todor", "Stefanov", 22, 21531, 
                        new List<double>() { 2, 4, 3, 5, 6, 2 }, "C# Advanced"), 
                        new Trainer("Atanas", "Rusenov", 20),
                        new SeniorTrainer("Filip","Kovachev", 24),
                        new JuniorTrainer("Rado", "Mihailov", 51),
                        new DropoutStudent("Kosta", "Mirkov", 25, 41251, new List<double>(){4,2,4,3,5},"Low attendance in lectures"),
                        new GraduateStudent("Poli", "Genova", 28, 212531, new List<double>(){5,5,4,5,2})
                        
    };
        var currentStudents =
            test
            .Where(student => student is CurrentStudent)
            .Select(student => (CurrentStudent)student)
            .OrderByDescending(student => student.AverageGrade);

        foreach (var student in currentStudents)
        {
            Console.WriteLine("First Name: {0}\nLast Name: {1}\nAge: {2}\nStudent Number: {3}\nAverage Grades: {4:F2}\nCourse: {5}", student.FirstName, student.LastName, student.Age, student.StudentNumber, student.AverageGrade, student.CurrentCourse);
            Console.WriteLine("----------------------------");
        }

        var dropoutStudents =
            test
             .Where(student => student is DropoutStudent)
            .Select(student => (DropoutStudent)student);

        foreach (var student in dropoutStudents)
        {
            student.Reapply();
            Console.WriteLine("----------------");
        }
        



    }
}

