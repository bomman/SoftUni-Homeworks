using System;
using CompanyHierarchy.Interfaces;

namespace CompanyHierarchy.Classes
{
    class Person : IPerson
    {
        private string firstName;
        private string lastName;
        private string id;

        public Person(string firstName, string lastName, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("FirstName", "The Name Cannot be empty space or null");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("LastName", "The Name Cannot be empty space or null");
                }
                this.lastName = value;
            }
        }
        public string Id
        {
            get { return this.id; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("ID", "The Id Cannot be empty space or null");
                }
                this.id = value;
            }
        }

        public override string ToString()
        {
            string result = string.Format("First Name: {0}\nLast Name: {1}\nId: {2}\n", this.FirstName, this.LastName, this.Id);
            return result;
        }
    }
}
