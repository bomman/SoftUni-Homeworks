using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using CompanyHierarchy.Enumarator;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes.Employees
{
    class Manager : Employee, IManager
    {
        private HashSet<Employee> managedEmployees;
        public Manager(string firstName, string lastName, string id, decimal salary, Department department, HashSet<Employee> managedEmployees)
            : base(firstName, lastName, id, salary, department)
        {
            this.ManagedEmployees = managedEmployees;
        }

        public HashSet<Employee> ManagedEmployees
        {
            get { return this.managedEmployees; }
            set { this.managedEmployees = value; }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Managed employees: {0}\n", string.Join(", ", ManagedEmployees.Select(x=> x.FirstName + " " +  x.LastName)) );
        }
    }
}
