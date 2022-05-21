using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class SubArrayWithGivenSum
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 8 };
            int n = 1;
            int s = 8;
            Console.WriteLine(string.Join(",",SubarraySum(arr, n, s)));
        }

        static List<int> SubarraySum(int[] arr, int n, int s)
        {
            if (n == 0) return new List<int>() { -1 };
            if(n == 1 && arr[0] != s) return new List<int>() { -1 };
            if (n == 1 && arr[0] == s) return new List<int>() { 1,1 };
            int i = 0; int j = 1;

            int sum = arr[i];
            while(j < n)
            {
                sum = sum  + arr[j];
                if (sum == s) return new List<int>() { i+1, j+1 };

                if (sum < s) j++;
                else 
                {
                    
                    i++;
                   
                    sum = arr[i];
                    if (sum == s) return new List<int>() { i + 1, i + 1 };
                    j = i+1;
                }
            }
            return new List<int>() { -1 };
        }
    }
}
