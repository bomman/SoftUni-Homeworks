using System;

class PointInACircle
{
    static void Main()
    {
        // Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 

        Console.WriteLine("Enter a point with coordinates X and Y to check if it is inside the circle:");
        IsItInsideTheCircle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        

        
    }
    public static void IsItInsideTheCircle (int x, int y)
    {
        
        int CircleCenterX = 0;
           int CircleCenterY = 0;
        int CircleRadius = 2;
       Console.WriteLine((x - CircleCenterX) * 2 + (y - CircleCenterY) * 2 <= CircleRadius * 2 ? " The point is inside the circle.  ": " The point IS NOT inside the circle." );
       
    }
}

