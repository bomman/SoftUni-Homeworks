using System;
using System.Globalization;
using System.Threading;
    class ComparingFloats
    {
        static void Main()
        {
           Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("Please enter a float number: ");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.Write("Please enter a float number: ");
            float secondNumber = float.Parse(Console.ReadLine());

            double eps = 0.000001;

            float difference = Math.Abs(firstNumber - secondNumber);
            bool equal = difference <= eps;

            if (equal == true)
            {
                Console.WriteLine("The numbers are equal!");
            }
            else
            {
                Console.WriteLine("The numbers are not equal!");
            }

        }
    }

