using System;
using System.Collections.Generic;
using System.Linq;
class EcryptMessages
{
    static void Main()
    {
        string command = Console.ReadLine();
        List<string> messages = new List<string>();
        int totalMessages = 0;
        Dictionary<char, char> specialSymbol = new Dictionary<char, char>
        {
             {' ', '+'},
             {',', '%'},
             {'.', '&'},
             {'?', '#'},
             {'!', '$'}

        };


        while (command != "START" && command != "start")
        {
            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "END" && command != "end")
        {
            if(command == "" || command == " " )
            {
                command = Console.ReadLine();
                continue;
            }
            else
            {
                messages.Add(command);
                totalMessages++;

            }
            
            command = Console.ReadLine();
        }
        string encryptedMessage = "";
       
         if (totalMessages != 0)
        {
            Console.WriteLine("Total number of messages: {0}", totalMessages);
        }
        else 
        {
            Console.WriteLine("No messages sent.");
        }
        for (int i = 0; i < messages.Count; i++)
        {
            for (int j = messages[i].Length - 1; j >= 0; j--)
            {
                if(char.IsLetter(messages[i][j]))
                {
                    if ((messages[i][j] < 78 && messages[i][j] > 64) || (messages[i][j] < 110 && messages[i][j] > 96))
                    {
                        encryptedMessage += (char)(messages[i][j]  + 13);
                    }
                    else if ((messages[i][j] > 77 && messages[i][j] < 91) || messages[i][j] > 109 )
                    {
                        encryptedMessage += (char)(messages[i][j] - 13);
                    }
                }
                else if (char.IsDigit(messages[i][j]))
                {
                    encryptedMessage += messages[i][j];
                }
                else if (specialSymbol.ContainsKey(messages[i][j]))
                {
                    encryptedMessage += specialSymbol[messages[i][j]];
                }
            }
            Console.WriteLine(encryptedMessage);
            encryptedMessage = "";
        }
                
    }
}

