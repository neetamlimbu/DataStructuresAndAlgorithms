using System;
using System.Collections.Generic;

namespace ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Container with most water...");

            int[] arr = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            Console.WriteLine(GetMaxArea(arr));
        }

        static int GetMaxArea(int[] input)
        {
            int maxArea = 0;

            //Brute Force
            // for (int i = 0; i < input.Length; i++)
            // {
            //     for (int j = 1; j < input.Length; j++)
            //     {
            //         int x = j - i;
            //         int y = input[i] <= input[j] ? input[i] : input[j];

            //         maxArea = Math.Max(maxArea, x * y);
            //     }
            // }

            //Sliding window
            //Slide right pointer to left if right pointer height is lesser than left pointer height and vice versa
            int left = 0, right = input.Length - 1;

            while (left < right)
            {
                int x = right - left;
                int y = input[left] <= input[right] ? input[left] : input[right];

                if (maxArea < (y * x))
                    maxArea = y * x;

                if (input[right] < input[left])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return maxArea;
        }
    }
}
