using System;
using System.Linq;
using System.Collections.Generic;
class Computer
{
    private string name;
    private double price;
    private List<Component> components;

    public Computer(string name, List<Component> components )
    {
        this.Name = name;        
        this.components = components;
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
        get { return components.Sum(price => price.Price); }
       
    }

    public override string ToString()
    {
       string computer = string.Format("name: {0}\ncomponents: {1}\nprice: {2}", name, string.Join("\n", components), price);
       return computer;
    }
}

