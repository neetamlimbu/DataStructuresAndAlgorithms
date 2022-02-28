using System;
using System.Linq;

namespace Anagrams
{
    class Program
    {
        //An anagram is a word or phrase that's formed by rearranging the letters of another word or phrase. 
        //For example, the letters that make up “A decimal point” can be turned into the anagram “I'm a dot in place.”
        static void Main(string[] args)
        {
            Console.WriteLine("Checking if two strings are anagrams...");

            //Test cases
            string testString1 = "silent";
            string testString2 = "listen";
            string testString3 = "restaurant";
            string testString4 = "runs    a    treat   ";
            string testString5 = "csharp";
            string testString6 = "programming";

            Console.WriteLine("Are {0} and {1} anagrams? {2}", testString1, testString2, IsValidAnagram(testString1, testString2) == true ?
            "Yes" : "No");
            Console.WriteLine("Are {0} and {1} anagrams? {2}", testString3, testString4, IsValidAnagram(testString3, testString4) == true ?
            "Yes" : "No");
            Console.WriteLine("Are {0} and {1} anagrams? {2}", testString5, testString6, IsValidAnagram(testString5, testString6) == true ?
            "Yes" : "No");
        }


        static bool IsValidAnagram(string first, string second)
        {
            first = first.Replace(" ", "").ToLower().Trim();
            second = second.Replace(" ", "").ToLower().Trim();

            if (first.Length != second.Length)
                return false;

            char[] firstArr = first.ToArray();
            char[] secondArr = second.ToArray();

            Array.Sort(firstArr);
            Array.Sort(secondArr);

            // //Brute Force 
            // for (int i = 0; i < firstArr.Count() - 1; i++)
            // {
            //     if (firstArr[i] != secondArr[i])
            //         return false;
            // }

            // return true;

            return firstArr.ToString().Equals(secondArr.ToString());
        }
    }
}
