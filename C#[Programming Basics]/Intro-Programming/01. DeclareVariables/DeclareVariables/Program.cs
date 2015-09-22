using System;



class DeclareVariables
{
    static void Main()
    {
        //Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the 
        //following values: 52130, -115, 4825932, 97, -10000.
        byte SmallNumber = 97;
        sbyte BiggerNUmber = -115;
        short BiggerThanByte = - 10000;
        int UsedForMostNumber = 52130;
        long ForTheBiggestNumbers = 4825932; // It can fit in int which will take us smaller amount of memory but I still decided to use Long to ensure if we need to multiple this number to have big enough type.

       // Console.WriteLine( SmallNumber); 
       // Console.WriteLine(BiggerNUmber); 
       // Console.WriteLine(BiggerThanByte);
        //Console.WriteLine(UsedForMostNumber); 
       // Console.WriteLine(ForTheBiggestNumbers);
    }
}

