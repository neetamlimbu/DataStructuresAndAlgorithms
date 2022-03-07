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
            Console.WriteLine(string.Format("LCM of {0} and {1} is {2}.", num1, num2, GetLCM(num1, num2)));
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
    }
}
