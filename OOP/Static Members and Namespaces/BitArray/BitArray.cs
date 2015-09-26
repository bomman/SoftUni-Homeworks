using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace BitArray
{
    class BitArray
    {
        private const int Max = 100000;
        private int size;
        private bool[] bits;

        public BitArray(int size)
        {
            this.Size = size;
            this.bits = new bool[size];
        }

        public int Size
        {
            get { return this.size; }
            set 
            {
                this.size = value;
                if (size < 1 || size > Max)
                {
                    Console.WriteLine("The size of the array can be maximum 100 000 and minimum 1");
                    throw new ArgumentOutOfRangeException();
                }
               
            }
        }

        public int this [int i]
        {
            get
            {
                if (i < 0 || i >= bits.Length)
                {
                    throw new IndexOutOfRangeException("Index is either too big or too small");
                }
                return bits[i] ? 1 : 0;
            }
            set
            {
                if(i < 0 || i >= bits.Length)
                {
                    throw new IndexOutOfRangeException("Index is either too big or too small");
                }
                if(value == 1)
                {
                    this.bits[i] = true;
                }
                else if(value == 0)
                {
                    this.bits[i] = false;
                }
                else
                {
                    throw new ArgumentException("A bit can be either 0 or 1");
                }
            }          
        }
        public BigInteger Value
        {
            get { return BitArrayToDecimalString(this.bits); }
        }
        public override string ToString()
        {
         return BitArrayToDecimalString(bits).ToString();
            
        }
        private BigInteger BitArrayToDecimalString(bool[] bits)
        {
            BigInteger result = 0;
            for (int i = bits.Length - 1; i >= 0; i--)
            {
                result <<= 1;
                result |= bits[i] == true ? 1 : 0;
            }


            return result;
        }

    }
}
