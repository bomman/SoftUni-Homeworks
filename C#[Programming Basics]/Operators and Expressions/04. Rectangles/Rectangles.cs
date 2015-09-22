using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter the width of the rectangle: ");
        int width = int.Parse(Console.ReadLine());

        Console.Write("Enter the height of the rectangle: ");
        int height = int.Parse(Console.ReadLine());

        int perimeter = 2 * (width + height);
        int area = width * height;

        Console.WriteLine("The perimeter is: {0}", perimeter);
        Console.WriteLine("The are is: {0}", area);
    }
}
