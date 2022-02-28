using System;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Word Count...");
            
            string testCase1 = "An apple a day keeps the doctor away.";
            string testCase2 = "       ";
            string testCase3 = null;


            Console.WriteLine(CountWords(testCase1));
            Console.WriteLine(CountWords(testCase2));
            Console.WriteLine(CountWords(testCase3));

        }

        static int CountWords(string str)
        {
            if(string.IsNullOrWhiteSpace(str))
                return 0;

            string[] words = str.Split(' ');
            return words.Length;
        }
    }
}
