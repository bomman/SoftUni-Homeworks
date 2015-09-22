using System;
using System.Linq;


class HalfSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr1 = new int[n];
        int[] arr2 = new int[n];
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }
        if (arr1.Sum() == arr2.Sum())
        {
            Console.WriteLine("Yes, sum={0}", arr1.Sum());
        }
        else
        {
            Console.WriteLine("No, diff={0}", Math.Abs(arr1.Sum() - arr2.Sum()));
        }

    }
}

