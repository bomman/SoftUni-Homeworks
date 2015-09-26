using System.Security.Cryptography.X509Certificates;

namespace CompanyHierarchy.Interfaces
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Id { get; set; }

    }
}
