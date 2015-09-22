using System;

class SandGlass
{
    static void Main()
    {
        short n = short.Parse(Console.ReadLine());

        Console.WriteLine(new string('*', n));

        for (int i = 2; i < n; i += 2)
        {
            int asteriksCount = n - i;
            string dots = new string('.', (n - asteriksCount) / 2);
            string asterisks = new string('*', asteriksCount);
            Console.Write(dots);
            Console.Write(asterisks);
            Console.Write(dots);
            Console.WriteLine();
        }
        for (int i = n - 3; i > 0; i -= 2)
        {
            int asteriksCount = n - i;
            string dots = new string('.', (n - asteriksCount) / 2);
            string asterisks = new string('*', asteriksCount);
            Console.Write(dots);
            Console.Write(asterisks);
            Console.Write(dots);
            Console.WriteLine();

        }
        Console.WriteLine(new string('*', n));

    }
}

