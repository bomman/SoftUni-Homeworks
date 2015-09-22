using System;

class MultiplicationSign
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber * secondNumber * thirdNumber > 0)
        {
            Console.WriteLine("+");
        }
        else if (firstNumber * secondNumber * thirdNumber == 0)
        {
            Console.WriteLine("0");
        }
        else if (firstNumber * secondNumber * thirdNumber < 0)
        {
            Console.WriteLine("-");
        }
    }
}

