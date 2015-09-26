using System;


class Persons
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Do you have an email ? (answer with yes  or no): ");
        string answer = Console.ReadLine();

        if (answer == "yes" || answer == "YES" || answer == "Yes")
        {
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            try
            {
                Person whoAreYou = new Person(name, age, email);
                Console.WriteLine(whoAreYou);
            }
            catch(ArgumentException)
            {
                Console.WriteLine("You have not entered valid data!");
            }
        }
        else
        {
            try
            {
                Person whoAreYou = new Person(name, age);
                Console.WriteLine(whoAreYou);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You have not entered valid data!");
            }
        }



    }
}

