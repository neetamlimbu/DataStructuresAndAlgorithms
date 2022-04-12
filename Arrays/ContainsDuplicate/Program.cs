using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contains Duplicate - LeetCode 217");

            // int[] nums = { 3, 3 };
            int[] nums = { 1, 2, 3, 1 };
            Console.WriteLine(ContainsDuplicate(nums));
        }

        static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length <= 1)
                return false;

            HashSet<int> list = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (list.Contains(nums[i]))
                    return true;
                else
                    list.Add(nums[i]);
            }

            return false;
        }
    }
}
