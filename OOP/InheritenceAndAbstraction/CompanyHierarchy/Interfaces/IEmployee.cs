using CompanyHierarchy.Enumarator;

namespace CompanyHierarchy.Interfaces
{
    interface IEmployee
    {
        decimal Salary { get; set; }

        Department Department { get; set; }
    }
}
