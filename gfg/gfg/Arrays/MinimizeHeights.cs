using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class MinimizeHeights
    {
        static void Main(string[] args)
        {

        }

        static int GetMinDiff(int[] arr, int n, int k)
        {
            if (arr == null || arr.Length == 0) return 0;

            Array.Sort(arr);
            int ans = arr[n - 1] - arr[0];

            int min = arr[0] + k;
            int max = arr[n - 1] - k;


            for (int i = 0; i < n - 1; i++)
            {
                int ma = Math.Max(max, arr[i] + k);
                int mi = Math.Min(min, arr[i + 1] - k);

                if (mi < 0) continue;

                ans = Math.Min(ans, ma - mi);
            }
            return ans;
        }
    }
}
