using System;

    class LongestWordInText
    {
        static void Main()
        {
            string[] text = Console.ReadLine().Split(' ','.');
            int maxLength = 0;
            int length = 0;
            string longestWord = "";
            for (int i = 0; i < text.Length; i++)
            {
                length = text[i].Length;
                if (length > maxLength)
                {
                    maxLength = length;
                    longestWord = text[i];
                }
            }
            Console.WriteLine(longestWord);
        }
    }

