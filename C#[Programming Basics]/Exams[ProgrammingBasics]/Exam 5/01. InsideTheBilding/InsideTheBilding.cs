using System;

class InsideTheBilding
{
    static void Main()
    {
        int h = int.Parse(Console.ReadLine());
        int xOne = int.Parse(Console.ReadLine());
        int yOne = int.Parse(Console.ReadLine());
        int xTwo = int.Parse(Console.ReadLine());
        int yTwo = int.Parse(Console.ReadLine());
        int xThree = int.Parse(Console.ReadLine());
        int yThree = int.Parse(Console.ReadLine());
        int xFour = int.Parse(Console.ReadLine());
        int yFour = int.Parse(Console.ReadLine());
        int xFive = int.Parse(Console.ReadLine());
        int yFive = int.Parse(Console.ReadLine());

        int bildingBase = h * 3;
        int bildingHeightCenter = h * 4;
        int bildingSidesHeight = h;

      
        IsItInsideTheBilding(xOne, yOne, h, bildingBase, bildingHeightCenter, bildingSidesHeight);
        IsItInsideTheBilding(xTwo, yTwo, h, bildingBase, bildingHeightCenter, bildingSidesHeight);
        IsItInsideTheBilding(xThree, yThree, h, bildingBase, bildingHeightCenter, bildingSidesHeight);
        IsItInsideTheBilding(xFour, yFour, h, bildingBase, bildingHeightCenter, bildingSidesHeight);
        IsItInsideTheBilding(xFive, yFive, h, bildingBase, bildingHeightCenter, bildingSidesHeight);
      


    }

    private static void IsItInsideTheBilding(int x, int y, int h, int bildingBase, int bildingHeightCenter, int bildingSidesHeight)
    {
        if (x >= 0 && x <= bildingBase && y >= 0 && y <= bildingHeightCenter)
        {
            if ((x <= h || x >= h * 2) && y <= bildingSidesHeight)
            {
                Console.WriteLine("inside");
            }
            else if (x >= h && x <= h * 2 && y <= bildingHeightCenter)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }

        }
        else
        {
            Console.WriteLine("outside");
        }
    }
}

