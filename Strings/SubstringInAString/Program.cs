using System;
using System.Collections;

namespace SubstringInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Substring in a string...");

            string[] testCases =
            {
                "a",
                "ab",
                "abc",
                "abcd",
                "   ",
                null
            };

            foreach (string testCase in testCases)
            {
                PrintSubstrings(testCase);
            }
        }

        static void PrintSubstrings(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return;

            Console.WriteLine("Substring for {0}", str);
            Console.WriteLine("---------------");

            //i => length of the substring to be extracted
            //i should not exceed length of substring -1
            //j => start index of the substring to be extracted
            //j should be less than  (total string length - length to be extracted)
            //In other words, total length >= i + j 
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = 0; j < str.Length - i; j++)
                {
                    //Console.WriteLine("i,j => {0},{1} for {2}", (i + 1), j, str.Substring(j, i + 1));
                    Console.WriteLine(str.Substring(j, i + 1));
                }
            }

            Console.WriteLine("---------------");
        }
    }
}
