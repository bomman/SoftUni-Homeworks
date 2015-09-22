using System;

class StudentsCables
{
    static void Main()
    {
        int numberOfCables = int.Parse(Console.ReadLine());
        int[] lengthOfTheCable = new int[numberOfCables];
        string[] measureOfTheCable = new string[numberOfCables];
        int joins = 0;
        int theLengthOfCables = 0;
        for (int i = 0; i < numberOfCables; i++)
        {
            lengthOfTheCable[i] = int.Parse(Console.ReadLine());
            measureOfTheCable[i] = Console.ReadLine();

            if (measureOfTheCable[i] == "meters")
            {
                lengthOfTheCable[i] *= 100; // from meters to centimeters
            }
            else if (measureOfTheCable[i] == "centimeters" && lengthOfTheCable[i] < 20)
            {
                continue;
            }
            theLengthOfCables += lengthOfTheCable[i];
            joins++;
        }

        theLengthOfCables = theLengthOfCables - 3 * (joins - 1);
        int studentsCables = theLengthOfCables / 504;
        int remainder = theLengthOfCables % 504;
        Console.WriteLine(studentsCables + "\n" + remainder);



    }
}

