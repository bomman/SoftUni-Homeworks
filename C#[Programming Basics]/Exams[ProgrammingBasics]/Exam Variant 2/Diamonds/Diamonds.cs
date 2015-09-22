using System;

class Diamonds
{
    static void Main()
    {

        double n = double.Parse(Console.ReadLine());

        Console.WriteLine(new string('-', (int)Math.Floor(n / 2)) + '*' + new string('-', (int)Math.Floor(n / 2)));

        for (int i = 1; i < n; i += 2)
        {
            int dasheshCount = (int)n - 2;
            int dasheshCenter = i;
            int dasheshAside = (dasheshCount - dasheshCenter) / 2;
            Console.Write(new string('-', dasheshAside) + '*' + new string('-', dasheshCenter) + '*' + new string('-', dasheshAside));
            Console.WriteLine();
        }
        for (int i = 2; i < n - 1; i += 2)
        {
            int dasheshCount = (int)n - 2;
            int dasheshAside = i / 2;
            int dasheshCenter = dasheshCount - i;

            Console.Write(new string('-', dasheshAside) + '*' + new string('-', dasheshCenter) + '*' + new string('-', dasheshAside));
            Console.WriteLine();
        }
        Console.WriteLine(new string('-', (int)Math.Floor(n / 2)) + '*' + new string('-', (int)Math.Floor(n / 2)));
    }
}
