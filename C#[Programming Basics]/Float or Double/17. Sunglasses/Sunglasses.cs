using System;

    class Sunglasses
    {
            static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string frames = new String('*', n * 2) + new String(' ', n) + new String('*', n * 2);

        string glass = new String('*', 1) + new String('/', (n * 2) - 2) + new String('*', 1) + new String(' ', n) + new String('*', 1) + new String('/', (n * 2) - 2) + new String('*', 1);

        string bridge = new String('*', 1) + new String('/', (n * 2) - 2) + new String('*', 1) + new String('|', n) + new String('*', 1) + new String('/', (n * 2) - 2) + new String('*', 1);


        Console.WriteLine(frames);

        for (int i = 0; i < n - 2; i++)
        {
            if (i == Math.Ceiling( (double)(n - 2) / 2) - 1)
            {
                Console.WriteLine(bridge);
            }
            else 
            {
                Console.WriteLine(glass);
            }
        }

        Console.WriteLine(frames);
    }
    }

