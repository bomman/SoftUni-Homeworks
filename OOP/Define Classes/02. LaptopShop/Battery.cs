using System;

public class Battery
{
    private string typeOfBattery;
    private double batteryLife;

    public Battery(string typeOfBattery, double batteryLife)
    {
        this.typeOfBattery = typeOfBattery;
        this.batteryLife = batteryLife;
    }

    public string TypeOfBatter
    {
        get
        {
            return this.typeOfBattery;
        }
        set 
        {
            if(value == string.Empty)
            {
                throw new ArgumentException("The type of battery cannot be without name...");
            }
            this.typeOfBattery = value;
        }
    }

    public double BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("The battery life cannot be a negative number.... ");
            }

            this.batteryLife = value;
        }
    }

    public override string ToString()
    {
        return string.Format("battery: {0}\nbattery life: {1} hours\n", typeOfBattery, batteryLife);
    }
}

