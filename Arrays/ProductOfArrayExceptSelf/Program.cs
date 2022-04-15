using System;
using System.Collections;

namespace ProductOfArrayExceptSelf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Product of Array Except Self - LeetCode 238");

            // Input: nums = [1,2,3,4]
            // Output: [24,12,8,6]

            // Input: nums = [-1,1,0,-3,3]
            // Output: [0,0,9,0,0]
            int[] nums = { 1, 2, 3, 4 };
            Array.ForEach(ProductExceptSelfBruteForce(nums), element => Console.Write(element + " "));
            Console.WriteLine();

            int[] nums2 = { -1, 1, 0, -3, 3 };
            Array.ForEach(ProductExceptSelfDivide(nums2), element => Console.Write(element + " "));
            Console.WriteLine();

            int[] nums3 = { 1, 2, 3, 4 };
            Array.ForEach(ProductExceptSelf(nums3), element => Console.Write(element + " "));
        }

        static int[] ProductExceptSelfBruteForce(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            ArrayList productList = new ArrayList();
            for (int i = 0; i < nums.Length; i++)
            {
                int index = nums.Length - 1;
                int product = 1;
                while (index >= 0)
                {
                    if (index != i)
                        product = product * nums[index];
                    index--;
                }
                productList.Add(product);
            }

            return (int[])productList.ToArray(typeof(int));
        }

        static int[] ProductExceptSelfDivide(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            int zeroCount = 0;
            int zeroCountIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    zeroCount++;
                    zeroCountIndex = i;
                }
            }

            if (zeroCount > 1)
                return new int[nums.Length];

            int prod = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    prod *= nums[i];
            }

            if (zeroCountIndex >= 0)
            {
                int[] result = new int[nums.Length];
                result[zeroCountIndex] = prod;
                return result;
            }

            for (int i = 0; i < nums.Length;)
            {
                nums[i] = prod / nums[i];
            }

            return nums;
        }

        static int[] ProductExceptSelf(int[] nums)
        {
            if (nums.Length == 0)
                return nums;

            int[] result = new int[nums.Length];

            //Fill the result array with 1
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = 1;
            }

            //Test Case 1
            // Input: nums = [1,2,3,4]
            // Output: [24,12,8,6]
            // ______________________          ___________________________      ______________________________________
            // |  index  |   prefix |          |  index   |   postfix    |      |  index  | result = prefix * postfix|
            // ----------------------          ---------------------------      --------------------------------------
            // |   0     |   1      |          |   3      |   1          |      |  3      |  6 * 1 = 6               |
            // ----------------------          ---------------------------      --------------------------------------
            // |   1     | 1 * 1 = 1|          |   2      |   4 * 1 = 4  |      |  2      |  2 * 4 = 8               | 
            // ----------------------          ---------------------------      --------------------------------------
            // |   2     | 1 * 2 = 2|          |   1      |   3 * 4 = 12 |      |  1      |  1 * 12 = 12             |
            // ----------------------          ---------------------------      --------------------------------------
            // |   3     | 2 * 3 = 6|          |   0      |   2 * 12 = 24|      |  0      |  1 * 24 = 24             |
            // ----------------------          ---------------------------      --------------------------------------

            int prefix = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = prefix;
                prefix *= nums[i];
            }

            int postfix = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                result[i] *= postfix;
                postfix *= nums[i];
            }

            return result;
        }
    }
}
