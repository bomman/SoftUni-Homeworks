using System;

class EnterNumber
{
    static void TryCatch(int[] numbers, int index, int lastIndex)
    {
        try
        {
            numbers[index] = int.Parse(Console.ReadLine());

            if (numbers[0] < 1)
            {
                throw new ArgumentException("The starting number cannot be less than 1!");
            }
            if (index != 0 && numbers[index] <= numbers[lastIndex])
            {
                throw new ArgumentException();
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The numbers must be in positive accretive sequence!");
        }
        catch (FormatException exOne)
        {
            Console.WriteLine(exOne.Message);
            Console.WriteLine("Enter the numbers again.");
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Enter the numbers again.");
        }
    }
    static void ReadNumber(int start, int end)
    {
        int[] numbers = new int[end - start];
        int index = 0;
        int lastIndex = index;
        for (int i = start; i < end; i++)
        {
            TryCatch(numbers, index, lastIndex);
            while(index != 0 && numbers[index] <= numbers[lastIndex])
            {
                TryCatch(numbers, index, lastIndex);
            }
            
            
            lastIndex = index;
            index++;
           
        }
    }
    static void Main()
    {
        int startNumber = int.Parse(Console.ReadLine());
        int endNumber = int.Parse(Console.ReadLine());
        while(startNumber >= endNumber)
        {
            if (endNumber <= startNumber)
            {
                throw new ArithmeticException("The end number cannot be smaller than the start number!");
            }

            startNumber = int.Parse(Console.ReadLine());
            endNumber = int.Parse(Console.ReadLine());
          
        }

        
        ReadNumber(startNumber, endNumber);
        
       
    }
}

