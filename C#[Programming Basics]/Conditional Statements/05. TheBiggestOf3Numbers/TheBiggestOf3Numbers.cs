using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine()); // the first number to check
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a > b && a  > c)
        {
            Console.WriteLine(a);
        }
        else if (b > c && b > a )
        {

            Console.WriteLine(b);
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}

