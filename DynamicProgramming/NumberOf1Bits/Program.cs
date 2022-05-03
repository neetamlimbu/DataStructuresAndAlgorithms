using System;

namespace NumberOf1Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of 1 Bits - LeetCode 191");
            uint n = BinaryToDecimal("00000000000000000000000000001011");
            Console.WriteLine(HammingWeight(11));
        }

        static int HammingWeight(uint n)
        {
            int count = 0;
            while (n > 0)
            {
                if (n % 2 != 0)
                    count++;

                n = n >> 1;
            }

            return count;
        }

        static uint BinaryToDecimal(string binaryNumber)
        {
            int decimalNumber = 0;
            int pow = 0;
            for(int i =  binaryNumber.Length -1; i >= 0; i--)
            {
               decimalNumber += ((int)Math.Pow(2,pow) * (int)char.GetNumericValue(binaryNumber[i]));
               pow++;
            }
            return (uint)decimalNumber;
        }
    }
}
