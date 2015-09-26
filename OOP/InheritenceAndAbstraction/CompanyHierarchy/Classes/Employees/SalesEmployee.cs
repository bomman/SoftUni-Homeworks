using System.Collections.Generic;
using System.Linq;
using CompanyHierarchy.Classes.Employees.AdditionalClasses;
using CompanyHierarchy.Enumarator;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes.Employees
{
    class SalesEmployee : Employee, ISaleEmployee
    {
        private HashSet<Sale> salesOfEmployee;
        public SalesEmployee(string firstName, string lastName, string id, decimal salary, Department department, HashSet<Sale> salesOfEmployee ) : base(firstName, lastName, id, salary, department)
        {
            this.SalesOfEmployee = salesOfEmployee;
        }

        public HashSet<Sale> SalesOfEmployee { get; set; }

        public override string ToString()
        {
            return base.ToString() + string.Format("Sales: {0}\n", string.Join(", ", SalesOfEmployee.Select(x => x.ProductName)));
        }
    }
}
