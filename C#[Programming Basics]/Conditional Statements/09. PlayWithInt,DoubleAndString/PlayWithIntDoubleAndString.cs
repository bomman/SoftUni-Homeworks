using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        int choise = int.Parse(Console.ReadLine());

        switch (choise)
        {
            case 1:
                Console.Write("Enter an integer number: ");
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer);
                break;
            case 2:
                Console.Write("Enter a floating number: ");
                double floatingNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(floatingNumber);
                break;
            case 3:
                Console.Write("Enter a string number: ");
                string stringInput = Console.ReadLine();
                Console.WriteLine(stringInput);
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}

