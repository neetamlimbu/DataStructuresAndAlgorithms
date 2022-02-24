using System;
using System.Collections;
using System.Text;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Removing duplicate characters from string...");

            //null or empty case
            string testCase1 = null;
            string testCase2 = "";

            if(string.IsNullOrEmpty(testCase1))
            {
                Console.WriteLine("String is null");
            }

            if(string.IsNullOrEmpty(testCase2))
            {
                Console.WriteLine("String is empty");
            }

            //sample test  1
            string testCase3 = "Google";

            ArrayList duplicateList = new ArrayList();
            StringBuilder sb = new StringBuilder();

            foreach(char c in testCase3)
            {
                if(!duplicateList.Contains(c))
                {
                    duplicateList.Add(c);
                    sb.Append(c);
                }
            }

            Console.WriteLine(sb);

        }
    }
}
