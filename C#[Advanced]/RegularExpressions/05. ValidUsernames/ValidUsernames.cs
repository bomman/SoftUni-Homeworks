using System;
using System.Text.RegularExpressions;

class ValidUsernames
{
    static void Main()
    {
        string text = Console.ReadLine();
        string pattern = @"(?<=[\\\/)( ])(?<username>[A-Za-z]\w{2,25})";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        int sum = 0;
        int bestSum = 0;
        int bestMatches = 0;
        for (int i = 0; i < matches.Count - 1; i++)
        {

            sum = matches[i].Length + matches[i + 1].Length;

            if (sum > bestSum)
            {
                bestSum = sum;
                bestMatches = i;
            }
        }


        Console.WriteLine("{0}\n{1}", matches[bestMatches], matches[bestMatches + 1]);


    }
}

