using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes.Employees.AdditionalClasses
{
    class Sale : ISale
    {
        private string productName;

        private double price;

        private DateTime date;
        public Sale(string productName, double price)
        {
            this.Price = price;
            this.ProductName = productName;
            this.Date = DateTime.Now;
        }

        public string ProductName
        {
            get { return this.productName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ProductName", "Product name cannot be empty or null.");
                }
                this.productName = value;
            }
        }

        public DateTime Date
        {
            get { return this.date; }
            private set { this.date = value; }

        }

        public double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price", "Price of sale cannot be a negative number");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Product Name: {0}\nDate: {1}\nPrice: {2}\n", ProductName, Date, Price);
        }
    }
}
