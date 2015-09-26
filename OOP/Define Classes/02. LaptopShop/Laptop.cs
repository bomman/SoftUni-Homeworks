using System;
using System.Text;


class Laptop
{


    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Battery battery;
    private double price;

    public Laptop(string model, double price)
    {
        this.Model = model;
        this.Price = price;
    }
    public Laptop(string model, string manufacturer, Battery battery = null, string processor = null, int ram = 0, string graphicsCard = null, string hdd = null, string screen = null, double price = 0)
        : this(model, price)
    {
        
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.battery = battery;
    
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The model must have a name!");
            }
            this.model = value;
        }
    }
    public string Manufacturer
    {
        get { return this.manufacturer; }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The manufacturer must have a name!");
            }
            this.manufacturer = value;
        }
    }
    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("You must enter data for the processor!");
            }
            this.processor = value;
        }
    }
    public int Ram
    {
        get { return this.ram; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The Ram memory cannot be less than 0!");
            }
            this.ram = value;
        }
    }
    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The graphic card must have a name!");
            }
            this.graphicsCard = value;
        }
    }
    public string Hdd
    {
        get { return this.hdd; }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The hdd must have a parameters!");
            }
            this.hdd = value;
        }
    }
    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (value == string.Empty)
            {
                throw new ArgumentException("The screen must have data!");
            }
            this.screen = value;
        }
    }
    public double Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("The price cannot be less than 0...");
            }
            this.price = value;
        }
    }


    
    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
            result.Append(string.Format("model: {0}\n", model));
        if(manufacturer != null)
        {
            result.Append(string.Format("manufacturer: {0}\n", manufacturer));
        }
        if (processor != null)
        {
            result.Append(string.Format("processor: {0}\n", processor));
        }
        if (ram != 0)
        {
            result.Append(string.Format("RAM: {0} GB\n", ram));
        }
        if (graphicsCard != null)
        {
            result.Append(string.Format("graphics card: {0}\n", graphicsCard));
        }
        if (hdd != null)
        {
            result.Append(string.Format("HDD: {0}\n", hdd));
        }
        if (screen != null)
        {
            result.Append(string.Format("screen: {0}\n", screen));
        }
        if (battery != null)
        {
            result.Append(battery);
        }
        if (price != 0)
        {
            result.Append(string.Format("price: {0:F2} lv.", price));
        }


        return result.ToString();
            
            
    }
}

