using System;
using System.Collections.Generic;
using System.Linq;

class JoinList
{
    static void Main()
    {

        List<string> allIntegers = new List<string>();
        string[] firstLineOfIntegers = Console.ReadLine().Split();
        string[] secondLineOfIntegers = Console.ReadLine().Split();

        for (int i = 0; i < firstLineOfIntegers.Length; i++)
        {
            int integer = int.Parse(firstLineOfIntegers[i]);
            allIntegers.Add(firstLineOfIntegers[i]);
        }
        for (int i = 0; i < secondLineOfIntegers.Length; i++)
        {
            int integer = int.Parse(secondLineOfIntegers[i]);
            allIntegers.Add(secondLineOfIntegers[i]);
        
        }
        for (int i = 0; i < allIntegers.Count - 1; i++)
        {
            for (int j  = i + 1; j  < allIntegers.Count  ; j ++)
            {
                if (allIntegers[i] == allIntegers[j])
                {
                    allIntegers.Remove(allIntegers[i]);
                    j = i ;
                    
                }
            }
          
        }

        allIntegers.Sort();

        foreach (var integer in allIntegers)
        {
            Console.Write(integer + " ");
        }
    }
}

