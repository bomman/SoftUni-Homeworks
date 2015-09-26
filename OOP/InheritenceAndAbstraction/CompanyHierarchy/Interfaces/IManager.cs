using System.Collections.Generic;
using CompanyHierarchy.Classes;

namespace CompanyHierarchy.Interfaces
{
    interface IManager
    {
        HashSet<Employee> ManagedEmployees { get; set; }
    }
}
