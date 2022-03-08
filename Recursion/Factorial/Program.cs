using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial...");

            //5! = 5 * 4 * 3 * 2 * 1
            //n! = n * (n-1)!
            Console.WriteLine("Factorial of {0} is {1}", 5, Factorial(5));
        }

        static int Factorial(int num)
        {
            //Base condition
            if (num == 0)
                return 1;
                
            return num * Factorial(num - 1);
        }
    }
}
