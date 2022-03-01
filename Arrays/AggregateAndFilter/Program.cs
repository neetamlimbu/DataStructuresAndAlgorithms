using System;
using System.Collections;

namespace AggregateAndFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Time complexity - O(n)
            //Space complexity - O(n)
            Console.WriteLine("Aggregate and filter arrays...");

            int[] arr1 = { -10, 20, 5, 9, 14, 32, -17};
            int[] arr2 = { 0, 3, -18, 23, 25, 33, 50};

            int[] evenNumbers = FindEvenNumbers(arr1, arr2);
            int[] oddNumbers = FindOddNumbers(arr1, arr2);

            Console.WriteLine("Even numbers:");
            Array.ForEach(evenNumbers, Console.WriteLine);
            Console.WriteLine("Odd numbers:");
            Array.ForEach(oddNumbers, Console.WriteLine);
        }

        static int[] FindEvenNumbers(int[] arr1, int[] arr2)
        {
            ArrayList evenNumbers = new ArrayList();

            foreach (int num in arr1)
            {
                if (GetRemainder(num) == 0)
                {
                    evenNumbers.Add(num);
                }
            }

             foreach (int num in arr2)
            {
                if (GetRemainder(num) == 0)
                {
                    evenNumbers.Add(num);
                }
            }

            return (int[])evenNumbers.ToArray(typeof(int));
        }

        static int[] FindOddNumbers(int[] arr1, int[] arr2)
        {
            ArrayList oddNumbers = new ArrayList();

            foreach (int num in arr1)
            {
                if (GetRemainder(num) != 0)
                {
                    oddNumbers.Add(num);
                }
            }

            foreach(int num in arr2)
            {
                if(GetRemainder(num) != 0)
                {
                    oddNumbers.Add(num);
                }
            }

            return (int[])oddNumbers.ToArray(typeof(int));
        }

        private static int GetRemainder(int num)
        {
            return num % 2;
        }
    }
}
