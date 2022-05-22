using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class SortZeroOneTwo
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 2, 1, 2, 0 };
            int n = 5;
            sort012(a, n);
        }

        static void sort012(int[] a, int n)
        {
            if (a == null || a.Length == 0) return;
            int numZeros = 0;
            int numOnes = 0;
            int numTwos = 0;

            for(int x=0; x<a.Length;x++)
            {
                if (a[x] == 0) numZeros++;
                if (a[x] == 1) numOnes++;
                if (a[x] == 2) numTwos++;
            }

            int i = 0;
            for(i =0;i<numZeros;i++)
            {
                a[i] = 0;
            }

            int k = 0;
            for(k = i; k< (numZeros+numOnes); k++)
            {
                a[k] = 1;
            }

            for(int j = k; j<(numZeros + numOnes+numTwos);j++)
            {
                a[j] = 2;
            }
        }
    }
}
