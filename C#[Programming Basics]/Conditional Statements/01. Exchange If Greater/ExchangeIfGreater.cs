using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine(b + " " + a);
        }
        else
        {
            Console.WriteLine(a + " " + b);
        }

    }
}

