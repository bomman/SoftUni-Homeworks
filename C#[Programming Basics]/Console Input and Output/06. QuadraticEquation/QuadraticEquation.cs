using System;

class QuadraticEquation
{
    static void Main()
    {
        // Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 

        int a = int.Parse(Console.ReadLine());
        double b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double xOne = new int();
        double xTwo = new int();

        double discriminant = (b * b) - (4 * a * c);

        if (discriminant > 0)
        {
            xOne = (-b + Math.Sqrt(discriminant)) / (2 * a); // the formula when the discriminant is positive
            xTwo = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine("The real roots are: {0} and {1}", xTwo, xOne);
        }

        else if ( discriminant == 0)
        {
            xOne = -(b / (2 * a));
        }

        else
        {
            Console.WriteLine("There are no real roots");
        }
    }
}

