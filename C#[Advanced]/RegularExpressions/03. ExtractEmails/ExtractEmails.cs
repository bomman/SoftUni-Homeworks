﻿////Write a program to extract all email addresses from a given text. The text comes at the only input line. Print the emails on the console, each at a separate line. Emails are considered to be in format <user>@<host>, where: 
//•	<user> is a sequence of letters and digits, where '.', '-' and '_' can appear between them. Examples of valid users: "stephan", "mike03", "s.johnson", "st_steward", "softuni-bulgaria", "12345". Examples of invalid users: ''--123", ".....", "nakov_-", "_steve", ".info". 
//•	<host> is a sequence of at least two words, separated by dots '.'. Each word is sequence of letters and can have hyphens '-' between the letters. Examples of hosts: "softuni.bg", "software-university.com", "intoprogramming.info", "mail.softuni.org". Examples of invalid hosts: "helloworld", ".unknown.soft.", "invalid-host-", "invalid-". 
//•	Examples of valid emails: info@softuni-bulgaria.org, kiki@hotmail.co.uk, no-reply@github.com, s.peterson@mail.uu.net, info-bg@software-university.software.academy. 
//•	Examples of invalid emails: --123@gmail.com, …@mail.bg, .info@info.info, _steve@yahoo.cn, mike@helloworld, mike@.unknown.soft., s.johnson@invalid-.

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

