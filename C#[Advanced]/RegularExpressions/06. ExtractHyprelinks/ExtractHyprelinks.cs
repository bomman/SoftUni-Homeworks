using System;
using System.Text;
using System.Text.RegularExpressions;

class ExtractHyperlinks
{
    static void Main()
    {
        // building the whole input and saving it in stringbuilder
        string inputLine = Console.ReadLine();
        StringBuilder htmlCode = new StringBuilder();
        while (inputLine != "END")
        {
            htmlCode.Append(inputLine);
            inputLine = Console.ReadLine();
        }
        string text = htmlCode.ToString();
       // getting the regex matches
        string pattern = @"<a\s+(?:[^>]+\s+)?href\s*=\s*(?:'(?<url>[^']*)'|""(?<url>[^""]*)""|(?<url>[^\s>]+))[^>]*>";
        Regex users = new Regex(pattern);
        MatchCollection matches = users.Matches(text);
       // printing the result.
        foreach (Match hyperlink in matches)
        {
            Console.WriteLine(hyperlink.Groups["url"]);
        }
    }
}