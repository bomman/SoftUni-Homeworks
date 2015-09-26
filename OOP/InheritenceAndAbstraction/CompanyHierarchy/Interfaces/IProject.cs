using System;
using CompanyHierarchy.Enumarator;

namespace CompanyHierarchy.Interfaces
{
    interface IProject
    {
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; set; }
        string Details { get; set; }
        StateOfProject State { get; }

        void CloseProject();


    }
}
