using System;

    class CirclePerimeterAndArea
    {
        static void Main()
        {
            //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 

            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double area = pi * (radius * radius);
            double perimeter = 2 * (pi * radius);

            Console.WriteLine("The area of the circle is: {0:F2}", area);
            Console.WriteLine("The perimeter of the circle is: {0:F2}", perimeter);

        }
    }

