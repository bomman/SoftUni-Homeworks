using System;


namespace HumanStudentWorker
{
    class Student : Human
    {
        private string facultyNumber;
        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("facultyNumber", "The faculty number cannot be more than 10 digits/letters and less than 5!");
                }
                this.facultyNumber = value;
            }
        }
    }
}
