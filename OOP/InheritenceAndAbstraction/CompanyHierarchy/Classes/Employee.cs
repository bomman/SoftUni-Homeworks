using System;
using System.Reflection;
using CompanyHierarchy.Enumarator;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;
        public Employee(string firstName, string lastName, string id, decimal salary, Department department) : base(firstName, lastName, id)
        {
            this.Department = department;
            this.Salary = salary;
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("salary", "Salary cannot be a negative number.");
                }
                this.salary = value;
            }
        }
        public Department Department { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("The Employee is a: {2}\nSalary: {0:F2}\nDepartment: {1}\n", this.Salary, this.Department, this.GetType().Name);
        }
    }
}
