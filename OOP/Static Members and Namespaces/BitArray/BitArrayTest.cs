using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class BitArrayTest
    {
        static void Main()
        {
            BitArray bits = new BitArray(8);
            bits[5] = 1;

            Console.WriteLine(bits);
            Console.WriteLine(bits.Value);
        }
    }
}
