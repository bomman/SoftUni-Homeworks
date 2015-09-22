using System;

    class Sunlight
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int wide = n * 3;
            Console.WriteLine(new string('.', (wide - 1) / 2) + new string('*', 1) + new string('.', (wide - 1) / 2));
            for (int i = 1; i <= n - 1; i++) // top 
            {
                int dotsAtEdge = i;
                int dotsAtCenter = (wide - (dotsAtEdge * 2) - 3) / 2;
                Console.WriteLine(new string('.', dotsAtEdge) + new string('*', 1) + new string('.', dotsAtCenter) + new string('*', 1) + new string('.', dotsAtCenter) + new string('*', 1) + new string('.', dotsAtEdge)) ;
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.WriteLine(new string('.', (wide - n) / 2) + new string('*', n) + new string('.', (wide - n) / 2));
            }
          
            
            Console.WriteLine(new string('*', wide)); // center

            for (int i = 0; i < n / 2; i++) // bottom
            {
                Console.WriteLine(new string('.', (wide - n) / 2) + new string('*', n) + new string('.', (wide - n) / 2));
            }
           
            for (int i = n - 1; i >= 1; i--)
            {
                int dotsAtEdge = i;
                int dotsAtCenter = (wide - (dotsAtEdge * 2) - 3) / 2;
                Console.WriteLine(new string('.', dotsAtEdge) + new string('*', 1) + new string('.', dotsAtCenter) + new string('*', 1) + new string('.', dotsAtCenter) + new string('*', 1) + new string('.', dotsAtEdge));
            }
            Console.WriteLine(new string('.', (wide - 1) / 2) + new string('*', 1) + new string('.', (wide - 1) / 2));
        }
    }

