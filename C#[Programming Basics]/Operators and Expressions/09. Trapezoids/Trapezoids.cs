using System;

class Trapezoids
{
    static void Main()
    {
        // Write an expression that calculates trapezoid's area by given sides a and b and height h.
        Console.Write("Enter side a:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter side b:");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter side height:");
        int h = int.Parse(Console.ReadLine());

        int area = ((a + b) / 2) * h;
        Console.WriteLine(" The area of the trapezoid is: " + area);

    }
}

