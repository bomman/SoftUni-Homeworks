using System.Collections.Generic;
using CompanyHierarchy.Classes.Employees.AdditionalClasses;

namespace CompanyHierarchy.Interfaces
{
    interface IDeveloper
    {
        HashSet<Project> ProjectsOfTheDeveloper { get; set; }
    }
}
