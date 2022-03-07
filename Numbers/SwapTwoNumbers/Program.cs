using System;

namespace SwapTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Swap two numbers...");

            int a = 52; //First Number
            int b = 37; //Second Number
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("First number is {0} and second number is {1}", a, b);
            Console.WriteLine("After swapping => first number is {0} and second number is {1}", a, b);
        }
    }
}
