using System;

    class ExchangeVariablesValues

    {
        static void Main()
        {
            // Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. Print the variable values before and after the exchange.

            int a = 5;
            int b = 10;
            int c = 10;// third variable to contain the value for "b".

            Console.WriteLine("before \"a\": {0}", a);
            Console.WriteLine("before \"b\": {0}", b);

            b = a;
            a = c;

            Console.WriteLine("after \"a\": {0}", a);
            Console.WriteLine("after \"b\": {0}", b);


        }
    }

