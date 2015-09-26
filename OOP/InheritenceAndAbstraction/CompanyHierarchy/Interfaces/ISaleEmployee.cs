using System.Collections.Generic;
using CompanyHierarchy.Classes.Employees.AdditionalClasses;

namespace CompanyHierarchy.Interfaces
{
    interface ISaleEmployee
    {
        HashSet<Sale> SalesOfEmployee { get; set; } 
    }
}
