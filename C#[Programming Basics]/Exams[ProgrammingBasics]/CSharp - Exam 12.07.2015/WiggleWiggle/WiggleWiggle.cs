using System;

class WiggleWiggle
{
    static void Main()
    {
        string[] numbers = Console.ReadLine().Split(' ');

        for (int i = 0; i < numbers.Length - 1; i += 2)
        {
            ulong firstNumberOfPair = ulong.Parse(numbers[i]);
            ulong secondNumberOfPair = ulong.Parse(numbers[i + 1]);
            string evenBitPositionFirstNumber = (firstNumberOfPair & 1).ToString();
            string oddBitBositionFirstNumber = ((firstNumberOfPair>>1) & 1).ToString();
            string evenBitPositionSecondNumber = (secondNumberOfPair & 1).ToString();
            string oddBitBositionSecondNumber = ((secondNumberOfPair >> 1) & 1).ToString();

            for (int movement = 0; movement < 61; movement += 2)
            {
                evenBitPositionFirstNumber += ((firstNumberOfPair >> 2) & 1).ToString();
                evenBitPositionSecondNumber += ((secondNumberOfPair >> 2) & 1).ToString();
                if(movement < 60)
                {
                    oddBitBositionFirstNumber += ((firstNumberOfPair >> 3) & 1).ToString();
                    oddBitBositionSecondNumber += ((secondNumberOfPair >> 3) & 1).ToString();
                }
              

                firstNumberOfPair >>= 2;
                secondNumberOfPair >>=2;
            }
         
            string firstNumberSwapped = "";
            string secondNumberSwapped = "";

            for (int bitPosition = evenBitPositionFirstNumber.Length - 1; bitPosition >= 0; bitPosition--)
            {
                firstNumberSwapped += evenBitPositionSecondNumber[bitPosition];
                secondNumberSwapped += evenBitPositionFirstNumber[bitPosition];
                if(bitPosition == 0)
                {
                    continue;
                }
                firstNumberSwapped += oddBitBositionFirstNumber[bitPosition - 1];
                secondNumberSwapped += oddBitBositionSecondNumber[bitPosition - 1];
            }

            string finalNumberFirst = "";
            string finalNumberSecond = "";

            for (int bitPosition = 0; bitPosition < firstNumberSwapped.Length; bitPosition++)
            {
                if(firstNumberSwapped[bitPosition] == '0')
                {
                    finalNumberFirst += '1';
                }
                else
                {
                    finalNumberFirst += '0';
                }
                if(secondNumberSwapped[bitPosition] == '0')
                {
                    finalNumberSecond += '1';

                }
                else
                {
                    finalNumberSecond += '0';
                }
            }

            long firstNumber = Convert.ToInt64(finalNumberFirst, 2);
            long secondNumber = Convert.ToInt64(finalNumberSecond, 2);

            Console.WriteLine("{0} {1}", firstNumber, finalNumberFirst);
            Console.WriteLine("{0} {1}", secondNumber, finalNumberSecond);


      
            
 


        }
    }
}

