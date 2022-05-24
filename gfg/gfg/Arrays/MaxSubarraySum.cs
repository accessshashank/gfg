using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class MaxSubarraySum
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, -2, 5 };
            int N = 5;
            Console.WriteLine(MaxSubarray(arr, N));
        }

        private static long MaxSubarray(int[] arr, int n)
        {
            long maxSum = long.MinValue;
            long localSum = 0;

            foreach (var a in arr)
            {
                localSum += a;
                maxSum = Math.Max(maxSum, localSum);
                if (localSum < 0)
                {
                    localSum = 0;
                }


            }

            return maxSum;
        }
    }
}
