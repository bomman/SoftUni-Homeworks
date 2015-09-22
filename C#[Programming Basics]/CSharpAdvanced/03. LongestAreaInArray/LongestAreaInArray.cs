using System;

class LongestAreaInArray
{
    static void Main()
    {
        int numberOfStrigs = int.Parse(Console.ReadLine());
        string[] sequenceOfStrings = new string [numberOfStrigs];
        string lastString = "";
        string longestSequenceOfString = "";
        string longestString = "";
        
        int longestSequence = 0;
        int sequence = 1;
        int maxElementsOfString =0;

        for (int i = 0; i < numberOfStrigs; i++)
        {
            sequenceOfStrings[i] = Console.ReadLine();

            if (sequenceOfStrings[i] == lastString)
            {
                sequence++;
            }
            else
            {
                sequence = 1;
            }

            if (sequence > longestSequence)
            {
                longestSequence = sequence;
                longestSequenceOfString = sequenceOfStrings[i];
            }

            if (sequenceOfStrings[i].Length > maxElementsOfString)
            {
                maxElementsOfString = sequenceOfStrings[i].Length;
                longestString = sequenceOfStrings[i];
            }

            lastString = sequenceOfStrings[i];          
        }

        if (longestSequence < 1)
        {
            
            Console.WriteLine(longestSequence);
            Console.WriteLine(longestString);
        }
        else
        {
            Console.WriteLine(longestSequence);
            for (int i = 0; i < longestSequence; i++)
            {
                Console.WriteLine(longestSequenceOfString);
            }
         
        }
    }
}

