using System;
using System.Text;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            // A palindrome is a word, number, phrase, or other sequence of characters 
            // which reads the same backward as forward, such as madam or racecar.
            Console.WriteLine("Palindrome...");

            string[] testCases =
            {
                "civic",
                "deleveled",
                "Hannah",
                "kayak",
                "level",
                "examiron",
                "racecar",
                "radar",
                "refer",
                "reviver",
                "easywcf",
                "rotator",
                "rotor",
                "sagas",
                "solos",
                "stats",
                "tenet",
                "",
                "         ",
                null
            };

            foreach (string value in testCases)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
            }
        }

        static bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;


            // //Brute Force method
            // StringBuilder reverseString = new StringBuilder();

            // for(int i = s.Length -1; i >= 0; i--)
            // {
            //     reverseString.Append(s[i]);
            // }

            // if(s.Equals(reverseString.ToString()))
            //     return true;


            int min = 0;
            int max = s.Length - 1;

            while (min < max)
            {
                if (s[min] != s[max])
                    return false;

                min++;
                max--;
            }

            return true;
        }
    }
}
