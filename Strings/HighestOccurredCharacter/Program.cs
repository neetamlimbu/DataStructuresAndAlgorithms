using System;
using System.Collections.Generic;
using System.Linq;

namespace HighestOccurredCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Highest Occurred Character...");

            string[] testCases = 
            {
                "word",
                "verse",
                "forward",
                "psychology",
                "   ",
                null
            };

            foreach(string testCase in testCases)
            {
                Console.WriteLine("{0} has the highest character {1}", testCase, CharacterWithHighestCount(testCase));
            }
        }

        static char CharacterWithHighestCount(string testCase)
        {
            if(string.IsNullOrWhiteSpace(testCase))
                return char.MinValue;

            Dictionary<char, int> characterList = new Dictionary<char, int>();
            foreach(char c in testCase)
            {
                if(characterList.ContainsKey(c))
                {
                    characterList[c] = characterList[c] + 1;
                }
                else
                {
                    characterList.Add(c, 1);
                }
            }

            var orderedList = characterList.OrderByDescending(d=> d.Value)
                .ToDictionary(d=> d.Key, d=> d.Value);

            var result = orderedList.FirstOrDefault().Key;

            return result;
        }
    }
}
