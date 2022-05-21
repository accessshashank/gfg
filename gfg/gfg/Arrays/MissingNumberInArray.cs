using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class MissingNumberInArray
    {
        static void Main(string[] args)
        {
            
        }

        static int MissingNumber(int[] array, int n)
        {
            int sum = n * (n - 1) / 2;
            int sum1 = 0;
            for(int i=0; i<array.Length;i++)
            {
                sum1 += array[i];
            }

            return sum - sum1;
        }
    }
}
