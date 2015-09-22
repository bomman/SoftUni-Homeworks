using System;



class SumOfElements
{
    static void Main()
    {
        string elements = Console.ReadLine();
        string[] elementsNumbers = elements.Split(' ');
        int sum = 0;
        int max = int.MinValue;

        for (int i = 0; i < elementsNumbers.Length; i++)
        {
            int element = int.Parse(elementsNumbers[i]);
            sum = sum + element;

            if (element > max)
            {
                max = element;
            }

        }
        if (sum == 2 * max)
        {
            Console.WriteLine("Yes, sum=" + max);
        }
        else
        {
            int diff = Math.Abs(sum - (max * 2));
            Console.WriteLine("No, diff=" + diff);
        }


    }
}
