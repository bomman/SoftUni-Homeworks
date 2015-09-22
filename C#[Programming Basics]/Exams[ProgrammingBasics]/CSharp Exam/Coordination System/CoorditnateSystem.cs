using System;

class CoorditnateSystem
{
    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine()); // the points on the system

        if (x == 0 && y == 0) // we are starting from the zero sector.
        {
            Console.WriteLine("0");
        }
        else if (y==0) // if the point is on the horizontal line
        {
            Console.WriteLine("6");
        }

        else if (x == 0) // if the point is on the vertical line
        {
            Console.WriteLine("5");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("1"); // top right corner
        }
        else if (x < 0 && y > 0) // top left corner
        {
            Console.WriteLine("2");
        }
        else if (x > 0 && y < 0) // bottom right corner
        {
            Console.WriteLine("4"); 
        }
        else if (x < 0 && y < 0) // bottom left corner
        {
            Console.WriteLine("3");
        }
    }
}

