using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagrams
{
    class Program
    {
        //An anagram is a word or phrase that's formed by rearranging the letters of another word or phrase. 
        //For example, the letters that make up “A decimal point” can be turned into the anagram “I'm a dot in place.”
        static void Main(string[] args)
        {
            Console.WriteLine("Valid Anagram - LeetCode 242");

            //Test cases
            string testString1 = "silent";
            string testString2 = "listen";
            string testString3 = "restaurant";
            string testString4 = "runs    a    treat   ";
            string testString5 = "csharp";
            string testString6 = "programming";
            string testString7 = "rat";
            string testString8 = "car";

            Console.WriteLine("Are {0} and {1} anagrams? {2}", testString1, testString2, IsValidAnagramASCII(testString1, testString2) == true ?
            "Yes" : "No");
            Console.WriteLine("Are {0} and {1} anagrams? {2}", testString3, testString4, IsValidAnagramASCII(testString3, testString4) == true ?
            "Yes" : "No");
            Console.WriteLine("Are {0} and {1} anagrams? {2}", testString5, testString6, IsValidAnagramASCII(testString5, testString6) == true ?
            "Yes" : "No");
            Console.WriteLine("Are {0} and {1} anagrams? {2}", testString7, testString8, IsValidAnagramASCII(testString7, testString8) == true ?
           "Yes" : "No");
        }


        static bool IsValidAnagramBruteForce(string first, string second)
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
            for (int i = 0; i < firstArr.Count(); i++)
            {
                if (firstArr[i] != secondArr[i])
                    return false;
            }

            return true;
        }

        static bool IsValidAnagram(string s, string t)
        {
            s = s.Replace(" ", "").ToLower().Trim();
            t = t.Replace(" ", "").ToLower().Trim();

            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> sMap = new Dictionary<char, int>();
            Dictionary<char, int> tMap = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (sMap.ContainsKey(s[i]))
                {
                    sMap[s[i]]++;
                }
                else
                {
                    sMap.Add(s[i], 1);
                }

                if (tMap.ContainsKey(t[i]))
                {
                    tMap[t[i]]++;
                }
                else
                {
                    tMap.Add(t[i], 1);
                }
            }

            foreach (char c in sMap.Keys)
            {
                if (!tMap.ContainsKey(c))
                    return false;

                if (sMap[c] != tMap[c])
                    return false;
            }

            return true;
        }

        static bool IsValidAnagramASCII(string s, string t)
        {
            s = s.Replace(" ", "").ToLower().Trim();
            t = t.Replace(" ", "").ToLower().Trim();

            if (s.Length != t.Length)
                return false;

            int[] count = new int[26];


            for (int i = 0; i < s.Length; i++)
            {
                count[(char)s[i] - 'a'] += 1;
            }

            int[] result = count;

            count = new int[26];
            for (int i = 0; i < t.Length; i++)
            {
                count[(char)t[i] - 'a'] += 1;
            }

            if (result.SequenceEqual(count))
                return true;

            return false;
        }
    }
}
