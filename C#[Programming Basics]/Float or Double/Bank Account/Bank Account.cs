using System;

    class BankAccount
    {
        static void Main()
        {
            // A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
            string firstName = "Simeon";
            string middleName = "Plamenov";
            string lastName = "Vanov";
            string IBAN = "UBBSS120429102421";
            double availableAmountOfMoney = 123566.89;
            string bankName = "Raiffeisen";

            Console.WriteLine("First Name: " + firstName + "\nMiddle Name: " + middleName + "\nLast Name: " + lastName + "\nIBAN: " + IBAN + "\nAvailable Amount of money:" + availableAmountOfMoney + "\nBank Name: " + bankName);
        }
    }

