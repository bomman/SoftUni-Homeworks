using System;

    class NumbersInIntervalDivided
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = Math.Min(number, numberTwo); i <= Math.Max(number, numberTwo); i++)
            {
                if (i % 5 == 0 )
                {
                    p++;
                              
                }

         

            }
            Console.WriteLine(p);
        }
    }

