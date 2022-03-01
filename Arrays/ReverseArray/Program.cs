using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse an array...");

            int[] arr = { 1, 3, 8, 9, 10, 12 };

            Console.WriteLine("Brute Force");
            arr = Reverse(arr);
            Array.ForEach(arr, Console.WriteLine);

            Console.WriteLine("Swap...");
            ReverseInPlace(arr);
            Array.ForEach(arr, Console.WriteLine);
        }

        //Brute Force
        //Time complexity - O(n)
        //Space complexity - O(n)
        static int[] Reverse(int[] input)
        {
            int[] reversed = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                reversed[input.Length - i - 1] = input[i];
            }

            return reversed;
        }

        //Swap
        //Time complexity - O(log n)
        //Space complexity - O(1)
        static void ReverseInPlace(int[] input)
        {
            for (int i = 0; i < input.Length / 2; i++)
            {
                int temp = input[i];
                input[i] = input[input.Length - i - 1];
                input[input.Length - i - 1] = temp;
            }
        }

    }
}
