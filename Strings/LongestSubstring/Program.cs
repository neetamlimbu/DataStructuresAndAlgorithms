using System;
using System.Collections.Generic;

namespace LongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Longest Substring...");
            Console.WriteLine(LongestSubstring(" "));
            Console.WriteLine(LongestSubstring("pwwkew")); //wke => 3
            Console.WriteLine(LongestSubstring("aab")); //ab => 2
            Console.WriteLine(LongestSubstring("dvdf"));
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
            int left = 0, right = 0;
            HashSet<char> chars = new HashSet<char>();

            while (right < s.Length)
            {
                char c = s[right];
                while (chars.Contains(c))
                {
                    chars.Remove(s[left]);
                    left++;
                }
                chars.Add(c);
                max = Math.Max(max, right - left + 1);
                right++;
            }

            return max;
        }
    }
}
