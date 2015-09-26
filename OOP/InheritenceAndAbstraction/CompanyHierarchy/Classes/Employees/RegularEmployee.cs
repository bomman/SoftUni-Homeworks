using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarchy.Enumarator;

namespace CompanyHierarchy.Classes.Employees
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(string firstName, string lastName, string id, decimal salary, Department department) : base(firstName, lastName, id, salary, department)
        {
        }
    }
}
