
namespace BookShop
{
    using  System;
    class Book
    {
        private string name;
        private string author;
        private double price;

        public Book(string name, string author, double price)
        {
            this.Name = name;
            this.Author = author;
            this.Price = price;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            protected  set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.name = value;
                }
            }
        }

        public string Author
        {

            get
            {
                return this.author;
            }
            protected  set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.author = value;
                }
            }
        }

        public virtual double Price
        {
            get
            {
                return this.price;
            }
            protected  set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new ArgumentException("Price cannot be a negative number!");
                }
            }
        }

        public override string ToString()
        {
            string result = string.Format("-Type: {0}\n-Title: {1}\n-Author: {2}\nPrice:{3:F2}$", this.GetType(), this.Name,
                this.Author, this.Price);
            return result;
        }
    }
}
