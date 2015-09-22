using System;

class Sort3NumbersWithNestedIfs
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine()); // the first number to check
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }

                
            }
            else if (b > c && b > a)
            {

                if (a > c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
                else
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
        }
    }

