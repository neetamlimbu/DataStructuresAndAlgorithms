using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search in Array...");

            //Assumption 
            //Array is sorted
            //Time complexity - O(log(n)) time

            int[] arr = { 1, 3, 10, 17, 25, 31, 40 };
            Console.WriteLine(Search(arr, 1));
            Console.WriteLine(Search(arr, 31));
            Console.WriteLine(Search(arr, 5));
            Console.WriteLine(Search(arr, 35));
        }

        static bool Search(int[] inputArr, int item)
        {
            int min = 0;
            int max = inputArr.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) /2;
                if (inputArr[mid] == item)
                {
                    return true;
                }
                else if(item < inputArr[mid])
                {
                    max = mid - 1;
                }
                else if(item > inputArr[mid])
                {
                    min = mid + 1;
                }
            }

            return false;
        }
    }
}
