using System;
using System.Collections;
using System.Collections.Generic;

namespace TopKFrequentElements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Top K Frequent Elements - LeetCode 347");

            // Input: nums = [1,1,1,2,2,3], k = 2
            // Output: [1,2]

            int[] nums = { 1, 1, 1, 2, 2, 3 };
            int[] result = TopKFrequent(nums, 2);
            Array.ForEach(result, element => Console.Write(element + " "));
        }

        static int[] TopKFrequent(int[] nums, int k)
        {
            if (nums.Length == k)
                return nums;

           Dictionary<int, int> number2Count = new Dictionary<int, int>();

            //we count how many times each number appears
            foreach (var num in nums)
            {
                number2Count.TryGetValue(num, out var temp);
                number2Count[num] = temp + 1;
            }

           List<int>[] bucket = new List<int>[nums.Length + 1];

            //we allocate an array in the size of the original list of numbers
            //we iterate all of the numbers and for add each number to the index in the array
            // the index represents how many times that number appeared
            //
            //    0 times -> none
            //    1 times -> number 3
            //    2 times -> number 2
            //    3 times -> number 1
            //    4 times -> none
            //    5 times -> none
            foreach (var key in number2Count.Keys)
            {
                int frequency = number2Count[key];
                if (bucket[frequency] == null)
                {
                    bucket[frequency] = new List<int>();
                }
                bucket[frequency].Add(key);
            }

            List<int> result = new List<int>();
            // we iterate the list bucket in reverse until the number of items in the result
            // list equals k, because we iterate in reserve we get the biggest numbers
            for (int pos = bucket.Length - 1; pos >= 0 && result.Count < k; pos--)
            {
                if (bucket[pos] != null)
                {
                    result.AddRange(bucket[pos]);
                }
            }

            return (int[]) result.ToArray();
        }
    }
}
