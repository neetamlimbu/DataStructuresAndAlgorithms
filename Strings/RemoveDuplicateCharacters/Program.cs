using System;
using System.Collections;
using System.Text;

namespace RemoveDuplicateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Remove Duplicate Characters...");

            string[] testCases = 
            {
                "different",
                "characters",
                "    ",
                null
            };

            foreach(string testCase in testCases)
            {
                Console.WriteLine("{0} after removing duplicate characters => {1}" , testCase, RemoveDuplicates(testCase));
            }
        }

        static string RemoveDuplicates(string s)
        {
            if(string.IsNullOrWhiteSpace(s))
                return s;

            ArrayList characters = new ArrayList();
            StringBuilder result = new StringBuilder();

            foreach(Char c in s)
            {
                if(!characters.Contains(c))
                {
                    characters.Add(c);
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
