using System;
using System.Collections.Generic;

namespace NumberOfLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Lines To Write String - LeetCode 806");

            int[] widths = { 4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            string s = "bbbcccdddaaa";
            int[] result = NumberOfLinesUsingASCII(widths, s);
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }

        static int[] NumberOfLines(int[] widths, string s)
        {
            string[] chars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z".Split(",");

            Dictionary<string, int> charMap = new Dictionary<string, int>();
            for (int i = 0; i < widths.Length; i++)
            {
                charMap.Add(chars[i], widths[i]);
            }

            int[] result = new int[2];
            int lines = 1;
            int totalPixels = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int pixels = charMap[s[i].ToString()];

                if ((totalPixels + pixels) > 100)
                {
                    lines++;
                    totalPixels = pixels;
                }
                else
                {
                    totalPixels += pixels;
                }
            }

            result[0] = lines;
            result[1] = totalPixels;
            return result;
        }

        static int[] NumberOfLinesUsingASCII(int[] widths, string s)
        {
            int lines = 1;
            int totalPixels = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                totalPixels += widths[c - 'a']; //Index of the character in width is c - 'a'
                if (totalPixels > 100)
                {
                    lines++;
                    totalPixels = widths[c - 'a'];
                }
            }

            int[] result = new int[2];
            result[0] = lines;
            result[1] = totalPixels;
            return result;
        }
    }
}
