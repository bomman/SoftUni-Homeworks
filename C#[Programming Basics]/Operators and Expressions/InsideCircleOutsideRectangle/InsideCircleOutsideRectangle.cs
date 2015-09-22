using System;

class InsideCircleOutsideRectangle
{
    static void Main()
    {
        //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 

        Console.WriteLine("Enter a point with coordinates X and Y");
        Console.Write("Enter X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y: ");
        double y = double.Parse(Console.ReadLine());
        int CircleCenterX = 1;
        int CircleCenterY = 1;
        double CircleRadius = 1.5;

        int rectangleTop = 1;
        int rectangleBottom = -1;
        int rectangleLeft = -1;
        int rectangleRight = 5;

        if ((x - CircleCenterX) * 2 + (y - CircleCenterY) * 2 <= CircleRadius * 2 && (y > rectangleTop || y < rectangleBottom || x > rectangleRight || x < rectangleLeft))
        {

            Console.WriteLine("Is the point inside a circle and outside a Rectangle: true");
        }
        else
        {
            Console.WriteLine("Is the point inside a circle and outside a Rectangle: false");
        }
    }
}