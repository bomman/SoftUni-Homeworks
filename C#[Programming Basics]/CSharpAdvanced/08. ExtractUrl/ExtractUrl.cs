using System;
using System.Text.RegularExpressions;
class ExtractUrl
{
    static void Main()
    {
     
        Regex linkParser = new Regex(@"\b(?:https?://|www\.)\S+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        string text = Console.ReadLine();
       
        foreach (Match m in linkParser.Matches(text))
        {
            Console.WriteLine(m);
        }
            
    }
}

