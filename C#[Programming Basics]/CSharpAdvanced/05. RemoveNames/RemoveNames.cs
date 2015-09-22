using System;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        List<string> allNames = new List<string>();
        string[] names = Console.ReadLine().Split();
        string[] namesToRemove = Console.ReadLine().Split();

        for (int i = 0; i < names.Length; i++)
        {
            allNames.Add(names[i]);
        }
        for (int i = 0; i < namesToRemove.Length; i++)
        {
            for (int j = 0; j < allNames.Count; j++)
            {
                if (namesToRemove[i] == allNames[j])
                {
                    allNames.Remove(namesToRemove[i]);
                    j--;
                }
            }
        }

        foreach (var name in allNames)
        {
            Console.Write(name + " ");
        }
    }
}

