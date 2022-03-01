using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Search in Array...");

            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(Search(arr, 4));
            Console.WriteLine(Search(arr, 10)) ;

            int[] arr2 = {};
            Console.WriteLine(Search(arr2, 5));

            //Using in built array functions
            int item = Array.Find(arr, element=> element == 3);
            Console.WriteLine(item);

            int[] items = Array.FindAll(arr, element => element >= 2);
            Array.ForEach(items, Console.WriteLine);
        }

        static int? Search(int[] input, int n)
        {
            if (input.Length == 0)
                return null;

            //Using Brute Force approach
            foreach (int current in input)
            {
                if (current == n)
                    return n;
            }

            return null;
        }
    }
}
