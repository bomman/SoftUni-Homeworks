using System;

class Tests
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Fib(n);
    }

    static long Fib(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        return Fib(n - 1) + (n - 2);
    }
}
