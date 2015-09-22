using System;

    class BitBuilder
    {
        static int bitCount = 0;
        static void Main()
        {
            long number = int.Parse(Console.ReadLine());
            int positon = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            
            while(command != "quit")
            {
                countBits(number);
                if(command == "flip")
                {
                    int mask = 1 << positon;
                    if (((number >> positon) & 1) == 1)
                    {
                        number = number & ~(1 << positon);
                    }
                    else
                    {
                        number = number | (1 << positon);
                    }
                }
                else if (command == "insert")
                {
                    long mask = 0;
                    for (int i = 0; i < positon; i++)
                    {
                        mask += (number >> i) & 1;
                    }
                }
            }

        }
        private static void countBits(long number)
        {
            long numToCount = number;
            bitCount = 0;

            while (numToCount > 0)
            {
                bitCount++;
                numToCount >>= 1;
            }
        }
    }

