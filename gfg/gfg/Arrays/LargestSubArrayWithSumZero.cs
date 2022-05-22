using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class LargestSubArrayWithSumZero
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -1, 1, - 1, 1 };
            int n = 4;
            Console.WriteLine(MaxLen(arr, n));
        }

        static int MaxLen(int[] arr, int n)
        {
            if (arr == null || arr.Length == 0) return -1;
            int sum = 0;
            int maxLen = 0;

            
            var dict = new Hashtable();

            for (int i = 0; i < arr.Length; i++)
            {   
                sum += arr[i];

                if (arr[i] == 0 && maxLen == 0) maxLen = 1;

                if (sum == 0)
                    maxLen = i + 1;

                if (dict.ContainsKey(sum)) // if sum already exists then there would have been subarray that would have contributed to zero sum
                {
                    maxLen = Math.Max(maxLen, i - (int)dict[sum]);
                }
                else
                {
                    dict.Add(sum, i);
                }

            }

            return maxLen;
        }
    }
}
