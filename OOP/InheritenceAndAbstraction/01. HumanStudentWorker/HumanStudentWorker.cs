using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace HumanStudentWorker
{
    class HumanStudentWorker
    {
        static List<Student> Students()
        {
            List<Student> students = new List<Student>()
                {
                 new Student("Ivan","Georgiev", "2142PRB"),
                 new Student("Georgi", "Ivanov", "RBP142039"),
                 new Student("Diana", "Vasileva", "RBP130429"),
                 new Student("Denica", "Genkova", "RBP130417"),
                 new Student("Simeon", "Vanov", "RBP1204918"),
                 new Student("Nesho", "Markov", "RBP1204916"),
                 new Student("Krasimir", "Zelev", "RBP1205924"),
                 new Student("Denis", "Kuimdjiiski","RBP120408"),
                 new Student("Aleksandrina", "Hadjieva", "RBP120403"),
                 new Student("Nikol","Staneva", "RBP1204908")
                };
            return students;
        }

        static List<Worker> Workers()
        {
            List<Worker> workers = new List<Worker>()
            {
                new Worker("Gosho", "Marinov", 124.16m, 8.5f, 3.54m),
                new Worker("Natasha", "Pironkova", 154.16m, 7.5f, 6.542m),
                new Worker("Plamen", "Nenov", 124.126m, 9.5f, 2.84m),
                new Worker("Andrea", "Karnegi", 224.16m, 6.5f, 7.154m),
                new Worker("Nikola", "Mollov", 154.16m, 8.5f, 3.94m),
                new Worker("Simeon", "Vanov", 1124.16m, 2.5f, 51.54m),
                new Worker("Diana", "Vasile", 1234.16m, 5.5f, 34.54m),
                new Worker("Izabela", "Yordanova", 24.16m, 18.5f, 1.244m),
                new Worker("Traqna", "Nichiq", 24.16m, 18f, 1.454m),
                new Worker("Denica", "Ivanova", 124.16m, 8.5f, 7.854m)
                };
            return workers;
        }


        static void Main()
        {
            List<Student> students = Students();
            var studentsOrderedByFacultyNumber = students
                .OrderBy(student => student.FacultyNumber);
            List<Worker> workers = Workers();
            var workersOrderedByPaymentPerHour = workers
                .OrderByDescending(worker => worker.MoneyPerHour);
            List<Human> workersAndStudents = workersOrderedByPaymentPerHour.Cast<Human>().ToList();
            workersAndStudents.AddRange(studentsOrderedByFacultyNumber);

            var workersAndStudentsOrderedByName = workersAndStudents
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName);
            
        }
    }
}
