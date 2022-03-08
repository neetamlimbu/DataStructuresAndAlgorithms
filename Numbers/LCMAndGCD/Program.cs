using System;

namespace LCMAndGCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LCM and GCD...");
            int num1 = 24;
            int num2 = 36;
            Console.WriteLine("LCM of {0} and {1} is {2}.", num1, num2, GetLCM(num1, num2));

            int num3 = 5;
            int num4 = 15;
            Console.WriteLine("GCD of {0} and {1} is {2}.", num3, num4, GetGCD(num3, num4));
        }

        static int GetLCM(int a, int b)
        {
            //Lowest Common Multiple or the smallest common multiple of two or more numbers
            //Example - to find LCM for 8 and 12
            //Multiples of 8 = 2 * 2 * 2
            //Mutiples of 12 = 2 * 2 * 3
            //The common multiples are 2 * 2 and the remainings are 2 from 8 and 3 from 12
            //The product of all prime factors = 2 * 2 * 2 * 3 = 24

            int smallerNumber, largerNumber;
            if (a < b)
            {
                smallerNumber = a;
                largerNumber = b;
            }
            else
            {
                smallerNumber = b;
                largerNumber = a;
            }

            for (int i = 1; i < smallerNumber; i++)
            {
                int mult = largerNumber * i;

                if (mult % smallerNumber == 0)
                {
                    return mult;
                }
            }

            return smallerNumber * largerNumber;
        }

        static int GetGCD(int a, int b)
        {
            int remainder;

            //Swap remainder until the remainder is 0
            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }
    }
}
