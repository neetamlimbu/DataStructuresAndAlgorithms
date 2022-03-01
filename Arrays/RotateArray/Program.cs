using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rotate an array to a given pivot...");

            //Time complexity - O(n)
            //Space ccomplexity - O(1)
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Rotating left...");
            Array.ForEach(RotateLeft(arr), Console.WriteLine);
            Console.WriteLine("Rotating right...");
            Array.ForEach(RotateRight(arr), Console.WriteLine);
        }

        static int[] RotateLeft(int[] input)
        {
            int temp = input[0];
            for (int i = 0; i < input.Length - 1; i++)
            {
                input[i] = input[i + 1];
            }
            input[input.Length - 1] = temp;

            return input;
        }

        static int[] RotateRight(int[] input)
        {
            int temp = input[input.Length - 1];
            for (int i = input.Length - 1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }
            input[0] = temp;

            return input;
        }
    }
}
