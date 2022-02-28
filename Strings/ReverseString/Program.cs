using System;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reverse String...");

            //Test Case 1
            string testCase1 = "hello world";
            string testCase2 = "";
            string testCase3 = null;
            
            Console.WriteLine(Reverse(testCase1));
            Console.WriteLine(Reverse(testCase2));
            Console.WriteLine(Reverse(testCase3));

        }

        static string Reverse(string str)
        {
            if(string.IsNullOrEmpty(str))
                return str;

            StringBuilder reverseString = new StringBuilder();
            for(int i=str.Length -1; i >= 0; i--)
            {
                reverseString.Append(str[i]);
            }

            return reverseString.ToString();
        }
    }
}
