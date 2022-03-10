using System;
using System.Collections;
using System.Collections.Generic;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 3, 4, 8, 5, 7 };
            Array.ForEach(TwoSum(arr, 9), element => Console.Write(element + " "));
        }

        //Index of two numbers to a given target
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int firstNumber = nums[i];
                int requiredNumber = target - firstNumber;

                if (map.ContainsKey(requiredNumber))
                {
                    int[] result = { map[requiredNumber], i };
                    return result;
                }

                if (!map.ContainsKey(firstNumber))
                {
                    map.Add(firstNumber, i);
                }
            }
            return null;
        }
    }
}
