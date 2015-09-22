using System;

    class Program
    {
        static void Main()
        {
            for (int i = 2006; i <= 2009; i++)
            {
                int[] year = new int[4];
                year[0] = (i / 1000) % 10;
                year[1] = (i / 100) % 10;
                year[2] = (i / 10) % 10;
                year[3] = i % 10;
                Console.WriteLine(year[3]);
            }
        }
    }

