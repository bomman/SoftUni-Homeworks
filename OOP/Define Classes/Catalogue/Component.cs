using System;

class Component
{
    private string name;
    private double price;
    private string details;

    public Component(string name, double price)
    {
        this.Name = name;
        this.Price = price;
    }
    public Component(string name, double price, string details)
        : this(name, price)
    {
        this.Details = details;
    }

    public string Name
    {
        get { return this.name; }
        set
        {
            if (value == null || value == string.Empty)
            {
                throw new ArgumentException("The name of the component cannot be empty");
            }
            this.name = value;
        }
    }
    public double Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be less than zero");
            }
            this.price = value;
        }
    }
    public string Details
    {
        get { return this.details; }
        set
        {
            if (value == string.Empty || value == null)
            {
                throw new ArgumentException("Details cannot be null or empty string");
            }
            this.details = value;
        }
    }
    public override string ToString()
    {
        string componentToString = "";
        if (details != string.Empty || details != null)
        {
            componentToString = string.Format("name: {0}\ndetails: {1}\nprice: {2:C}", name, details, price);
        }
        else
        {
            componentToString = string.Format("name: {0}\nprice: {1:C}", name, price);
        }
        return componentToString;
    }
}

