using System;

namespace CountingBits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counting Bits - LeetCode 338");
            Console.Write("[ ");
            Array.ForEach(CountBits(2), ele => Console.Write(ele + " "));
            Console.Write("] ");
        }

        static int[] CountBits(int n)
        {
            int[] res = new int[n + 1];

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0) //Even
                {
                    res[i] = res[i / 2];
                }
                else            //Odd
                {
                    res[i] = 1 + res[i - 1];
                }
            }

            return res;
        }
    }
}
