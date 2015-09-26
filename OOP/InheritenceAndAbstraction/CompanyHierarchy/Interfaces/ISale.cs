using System;

namespace CompanyHierarchy.Interfaces
{
    interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get;  }
        double Price { get; set; }
    }
}
