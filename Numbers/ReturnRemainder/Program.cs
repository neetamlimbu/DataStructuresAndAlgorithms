using System;

namespace ReturnRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Return Remainder...");
            // Console.WriteLine(ReturnRemainder(20, 0));
            // Console.WriteLine(ReturnRemainder(5, 8));
            Console.WriteLine(ReturnRemainder(10, 2));
            Console.WriteLine(ReturnRemainder(11, 2));
        }

        static int ReturnRemainder(int x, int y)
        {
            if (y == 0)
            {
                throw new Exception(string.Format("Cannot divide {0} by zero.", x));
            }
            else if (x < y)
            {
                throw new Exception(string.Format("Number being divided {0} cannot be less than divisor {1}.", x, y));
            }
            else
            {
                return (x % y);
            }
        }
    }
}
