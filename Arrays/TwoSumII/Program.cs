using System;

namespace TwoSumII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two Sum II...");
            int[] arr1 = { 2, 7, 11, 15 };
            Array.ForEach(TwoSum(arr1, 9), element => Console.Write(element + " "));
            Console.WriteLine();
            int[] arr2 = { 0, 0, 3, 4 };
            Array.ForEach(TwoSum(arr2, 0), element => Console.Write(element + " "));
            Console.WriteLine();
            int[] arr3 = { 2, 3, 4 };
            Array.ForEach(TwoSum(arr3, 6), element => Console.Write(element + " "));
        }

        static int[] TwoSum(int[] input, int target)
        {
            if (input.Length == 0)
                return null;

            int left = 0;
            int right = input.Length - 1;
            int sum = 0;

            while (left < right)
            {
                sum = input[left] + input[right];

                if (sum == target)
                {
                    return new int[] { left + 1, right + 1 };
                }
                else if (sum > target)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return null;
        }
    }
}
