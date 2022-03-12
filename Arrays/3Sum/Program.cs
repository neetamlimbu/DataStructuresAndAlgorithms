using System;
using System.Collections;
using System.Collections.Generic;

namespace _3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3Sum");

            int[] arr = { -1, 0, 1, 2, -1, -4 };

            IList<IList<int>> result = ThreeSum(arr);
            foreach (IList array in result)
            {
                Console.Write("[ ");
                foreach (int item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("]");
            }
        }

        static IList<IList<int>> ThreeSum(int[] nums)
        {
            //Sort the array so that the integers are sorted in ascending order
            Array.Sort(nums); //O(logn)

            IList<IList<int>> result = new List<IList<int>>();

            //For triplets, three pointers are assigned to compute the sum
            for (int i = 0; i < nums.Length - 2; i++) //O(n)
            {

                if (i > 0 && nums[i] == nums[i - 1]) //[-1, -1, -1, 0, 1, 2] - Test case where when duplicates found, go to beginning of for loop and increment i
                {
                    continue; //Loop back to for loop 
                }

                int left = i + 1; ;
                int right = nums.Length - 1;

                while (left < right)  //O(n)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
                        //{ -1, -1, 0, 0, 1, 1, 1, 2, 2, 3, 4, 4, 4 } - Test case where the array might still contain duplicates

                        while (left < right && nums[left] == nums[left + 1])
                        {
                            left++;
                        }

                        while (left < right && nums[right] == nums[right - 1])
                        {
                            right--;
                        }

                        left++;
                        right--;
                    }
                    else if (sum > 0)
                    {
                        right--; //Since the array is sorted and greater elements are located at the right 
                    }
                    else
                    {
                        left++;
                    }
                }
            }

            return result;
        }
    }
}
