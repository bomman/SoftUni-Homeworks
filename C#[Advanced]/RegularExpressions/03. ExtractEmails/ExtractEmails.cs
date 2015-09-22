using System;
using System.Text.RegularExpressions;


class ExtractEmails
{
    static void Main()
    {
        //Write a program to extract all email addresses from a given text. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format <user>@<host>.
        string input = Console.ReadLine();
        string pattern = @"\b[\w_.]+@[._\w]+\.\w+\b";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(input);
        foreach(var match in matches)
        {
            Console.WriteLine(match);
        }
    }
}

