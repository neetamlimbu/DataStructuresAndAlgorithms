using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort...");

            int[] arr = { 7, 12, 8, 3, 9, 14, 2, 6, 10 };
            // Array.ForEach(Sort(arr), element => Console.Write(element + " "));

            Array.ForEach(SortRecursive(arr, arr.Length), element => Console.Write(element + " "));
        }

        static int[] Sort(int[] input)
        {
            //Brute Force
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j < input.Length - i; j++)
                {
                    if (input[j] < input[j - 1])
                    {
                        Swap(input, j, j - 1);
                    }
                }
            }

            return input;
        }

        static int[] SortRecursive(int[] input, int j)
        {
            // Base case
            if (j == 1)
                return null;

            // One pass of bubble
            // sort. After this pass,
            // the largest element
            // is moved (or bubbled)
            // to end.
            for (int i = 0; i < j - 1; i++)
            {
                if (input[i + 1] < input[i])
                {
                    Swap(input, i + 1, i);
                }
            }

            // Largest element is fixed,
            // recur for remaining array
            SortRecursive(input, j - 1);

            return input;
        }

        private static void Swap(int[] input, int index1, int index2)
        {
            int temp = input[index1];
            input[index1] = input[index2];
            input[index2] = temp;
        }
    }
}
