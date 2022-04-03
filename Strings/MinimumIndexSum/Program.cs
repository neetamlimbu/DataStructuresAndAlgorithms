using System;
using System.Collections;
using System.Collections.Generic;

namespace MinimumIndexSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minimum Index Sum of Two Lists - LeetCode 599");

            string[] list1 = { "Shogun", "Tapioca Express", "Burger King", "KFC" };
            string[] list2 = { "KFC", "Shogun", "Burger King" };

            string[] result = FindRestaurantBruteForce(list1, list2);
            Console.WriteLine("Using Brute Force...");
            Array.ForEach(result, Console.WriteLine);

            result = FindRestaurantUsingDictionary(list1, list2);
            Console.WriteLine("Using Dictionary...");
            Array.ForEach(result, Console.WriteLine);
        }

        static string[] FindRestaurantBruteForce(string[] list1, string[] list2)
        {
            ArrayList result = new ArrayList();
            int minIndex = int.MaxValue;

            for (int i = 0; i < list1.Length; i++)
            {
                for (int j = 0; j < list2.Length; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        if (minIndex > (i + j))
                        {
                            minIndex = i + j;
                            result.Clear();
                            result.Add(list1[i]);
                        }
                        else if (minIndex == (i + j))
                        {
                            result.Add(list1[i]);
                        }
                    }
                }
            }

            return (string[])result.ToArray(typeof(string));
        }


        static string[] FindRestaurantUsingDictionary(string[] list1, string[] list2)
        {
            Dictionary<string, int> resList = new Dictionary<string, int>();

            int minIndex = int.MaxValue;
            for (int i = 0; i < list1.Length; i++)
            {
                if (!resList.ContainsKey(list1[i]))
                {
                    resList.Add(list1[i], i);
                }
            }

            ArrayList result = new ArrayList();
            for (int i = 0; i < list2.Length; i++)
            {
                if (resList.ContainsKey(list2[i]))
                {
                    int index = resList[list2[i]];
                    if (minIndex > (index + i))
                    {
                        minIndex = index + i;
                        result.Clear();
                        result.Add(list2[i]);
                    }
                    else if (minIndex == (index + i))
                    {
                        result.Add(list2[i]);
                    }
                }
            }

            return (string[])result.ToArray(typeof(string));
        }

    }
}
