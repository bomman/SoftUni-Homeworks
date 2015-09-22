using System;

    class QuotedStrings
    {
        static void Main()
        {
            string firstquotes = "The \"use\" of quotation causes difficulties";
            string secondquotes = "The" + '\u0022' + "use" + '\u0022' + "of quotation causes difficulties";

            Console.WriteLine("Quotes escape: {0}", firstquotes);
            Console.WriteLine("Quotes with char: {0}", secondquotes);
        }
    }

