using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class LongestCommonPrefix
    {
        static void Main(string[] args)
        {
            string[] arr = new string[] {"geeksforgeeks", "geeks", "geek",  "geezer"};
            int n = 4;
            Console.WriteLine(LongestCommonPre(arr, n));
            Console.WriteLine(LongestCommonPrefixNiceApproach(arr, n));
        }

        static string LongestCommonPre(string[] arr, int n)
        {
            if (arr == null || arr.Length == 0) return "-1";
            string shortest = "";
            int len = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].Length < len)
                {
                    len = arr[i].Length;
                    shortest = arr[i];
                }
            }
           

            int total = arr.Length;
            int counter = 0;

            while(counter < total && !string.IsNullOrEmpty(shortest))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    string item = arr[i];
                    if(item.StartsWith(shortest))
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 0;
                        shortest = shortest.Substring(0, shortest.Length - 1);
                        break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(shortest)) return shortest;
            return "-1";
        }

        static string LongestCommonPrefixNiceApproach(string[] arr, int n)
        {
            if (arr == null || arr.Length == 0) return "-1";

            Array.Sort(arr);

            string p1 = arr[0];
            string p2 = arr[arr.Length - 1];

            string common = "";
            int i = 0; int j = 0;

            while(i < p1.Length && j < p2.Length)
            {
                if(p1[i] == p2[j])
                {
                    common = common + p1[i];
                    i++; j++;
                }
                else
                {
                    break;
                }
            }

            if (common == "") return "-1";
            return common;
        }
    }
}
