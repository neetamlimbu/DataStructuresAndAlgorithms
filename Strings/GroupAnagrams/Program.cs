using System;
using System.Collections;
using System.Collections.Generic;

namespace GroupAnagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Group Anagrams - LeetCode 49");

            // Input: strs = ["eat","tea","tan","ate","nat","bat"]
            // Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            IList<IList<string>> result = GroupAnagrams(strs);

            foreach(List<string> anagrams in result)
            {
                Console.Write("[");
                foreach(string anagram in anagrams)
                {
                    Console.Write(anagram + " ");
                }
                Console.Write("]");
            }
        }

        static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            if(strs.Length == 0)
             return new List<IList<string>>();

            IList<IList<string>> groupedAnagrams = new List<IList<string>>();
            Dictionary<string, List<string>> anagramMap = new Dictionary<string, List<string>>();

            foreach (string str in strs)
            {
                char[] charArray = str.ToCharArray();
                Array.Sort(charArray);
                string sorted = new string(charArray);

                if (anagramMap.ContainsKey(sorted))
                {
                    anagramMap[sorted].Add(str);
                }
                else
                {
                    anagramMap.Add(sorted, new List<string> { str });
                }
            }

            foreach (List<string> anagramList in anagramMap.Values)
            {
                groupedAnagrams.Add(anagramList);
            }

            return groupedAnagrams;
        }
    }
}
