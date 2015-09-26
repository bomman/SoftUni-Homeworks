using System.Collections.Generic;
using System.Linq;
using CompanyHierarchy.Classes.Employees.AdditionalClasses;
using CompanyHierarchy.Enumarator;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes.Employees
{
    class Developer : Employee, IDeveloper
    {
        private HashSet<Project> projectsOfTheDeveloper; 
        public Developer(string firstName, string lastName, string id, decimal salary, Department department, HashSet<Project> projectsOfTheDeveloper ) : base(firstName, lastName, id, salary, department)
        {
            this.ProjectsOfTheDeveloper = projectsOfTheDeveloper;
        }

        public HashSet<Project> ProjectsOfTheDeveloper { get; set; }
        public override string ToString()
        {
            return base.ToString() +
                   string.Format("Projects Of The Developer: {0}\n", string.Join(", ", ProjectsOfTheDeveloper.Select(x => x.ProjectName)));
        }
    }
}
