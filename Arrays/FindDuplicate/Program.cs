using System;

namespace FindDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the Duplicate Number - LeetCode 287");

            //int[] nums = { 1, 3, 4, 2, 2 };
            // [3,1,3,4,2]
            int[] nums = { 3, 1, 3, 4, 2 };
            Console.WriteLine(FindDuplicate(nums));
        }

        static int FindDuplicateBruteForce(int[] nums)
        {
            int right = nums.Length - 1;

            for (int left = 0; left < right; left++)
            {
                while (right > left)
                {
                    if (nums[left] == nums[right])
                    {
                        return nums[left];
                    }

                    right--;
                }
                right = nums.Length - 1;
            }

            return -1;
        }

        //Floyd Algorithm
        static int FindDuplicate(int[] nums)
        {
            int slow = nums[0];
            int fast = nums[0];
            do
            {
                slow = nums[slow];
                fast = nums[nums[fast]];
            }
            while (slow != fast);

            fast = nums[0];
            while (slow != fast)
            {
                slow = nums[slow];
                fast = nums[fast];
            }
            return slow;
        }
    }
}
