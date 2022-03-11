using System;
using System.Collections.Generic;

namespace LongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Substring...");
            Console.WriteLine(LongestSubstring(" ")); //whitespace => 1
            Console.WriteLine(LongestSubstring("pwwkew")); //wke => 3
            Console.WriteLine(LongestSubstring("aab")); //ab => 2
            Console.WriteLine(LongestSubstring("dvdf")); //vdf => 3
            Console.WriteLine(LongestSubstring("abcabcbb")); //abc => 3
            Console.WriteLine(LongestSubstring("bbbbb")); //b=> 1
        }

        static bool CheckRepetition(string subString)
        {
            char[] charCount = new char[256];

            for (int i = 0; i < subString.Length; i++)
            {
                char c = subString[i];
                charCount[c]++;

                if (charCount[c] > 1)
                {
                    return false;
                }
            }
            return true;
        }

        static int LongestSubstring(string s)
        {
            if (s == null || s.Length == 0)
                return 0;

            int max = 0;

            //Brute force
            // for (int i = 0; i < s.Length; i++)
            // {
            //     for (int j = 0; j < s.Length - i; j++)
            //     {
            //         if (CheckRepetition(s.Substring(j, i + 1)))
            //         {
            //             max = Math.Max(max, i + 1);
            //         }
            //     }
            // }

            //Sliding window
            int left = 0, right = 0; //Left and right pointer to index
            HashSet<char> chars = new HashSet<char>();

            while (right < s.Length)
            {
                //Add the new character to hashset if it does not already exist in hashset which will increase the size of our sliding window
                //When a duplicate character is encountered in hashset, start removing the characters using left pointer until we reach to the index of duplicate character
                //The above step will decrease the size of our sliding window
                while (chars.Contains(s[right]))
                {
                    chars.Remove(s[left]);
                    left++;
                }

                chars.Add(s[right]);
                max = Math.Max(max, right - left + 1); //Since we start from 0 index, we add 1 to balance our count
                right++;
            }

            return max;
        }
    }
}
