using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    class Customer : Person, ICustomer
    {
        private double netPurchaseAmount;
        public Customer(string firstName, string lastName, string id, double netPurchaseAmount)
            : base(firstName, lastName, id)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public double NetPurchaseAmount
        {
            get { return this.netPurchaseAmount; }
            set
            {
                this.netPurchaseAmount = value;
            }
        }
    }
}
