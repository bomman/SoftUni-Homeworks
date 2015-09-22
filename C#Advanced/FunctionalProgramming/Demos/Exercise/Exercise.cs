using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Exercise
    {
        static void Main()
        {
            StringBuilder alphabet = new StringBuilder();
            for (int i = 'a'; i < 'z'; i++)
            {
                alphabet.Append((char)i);
            }

            string halfOfAlphabet = alphabet.Substring(15, 10);
            Console.WriteLine(halfOfAlphabet);
        }
    }


