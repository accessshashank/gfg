using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class SwappingPairsMakeSumEqual
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 3, 6, 3, 3 };
            int N = 4;
            int[] B = new int[] { 4, 1, 2, 1, 1, 2 };
            int M = 6;

            Console.WriteLine(FindSwapValues(A, N, B, M));
            Console.WriteLine(FindSwapValuesNiceApproach(A, N, B, M));
        }

        static int FindSwapValues(int[] A, int n, int[] B, int m)
        {
            if (A == null || A.Length == 0) return -1;
            if (B == null || B.Length == 0) return -1;

            int sumA = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];
            }
            int sumB = 0;

            for (int i = 0; i < B.Length; i++)
            {
                sumB += B[i];
            }

            if ((sumA + sumB) % 2 == 1) return -1;
            int targetSum = (sumA + sumB) / 2;

            var ht = new Hashtable();
            
            if(sumA > sumB)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    ht[A[i]] = 0;
                }

                for (int i = 0; i < B.Length; i++)
                {
                    int val = targetSum - (sumB- B[i]);
                    if(ht.ContainsKey(val))
                    {
                        return 1;
                    }
                }
            }
            else if(sumB > sumA)
            {
                for (int i = 0; i < B.Length; i++)
                {
                    ht[B[i]] = 0;
                }

                for (int i = 0; i < A.Length; i++)
                {
                    int val = targetSum - (sumA - A[i]);
                    if (ht.ContainsKey(val))
                    {
                        return 1;
                    }
                }
            }
            return -1;
        }

        static int FindSwapValuesNiceApproach(int[] A, int n, int[] B, int m)
        {
            int sumA = 0;
            for (int k = 0; k < A.Length; k++)
            {
                sumA += A[k];
            }
            int sumB = 0;

            for (int k = 0; k < B.Length; k++)
            {
                sumB += B[k];
            }

            int target = 0;

            if((sumA - sumB)%2 != 0)
            {
                return -1;
            }

            target = (sumA - sumB) / 2;

            Array.Sort(A);
            Array.Sort(B);

            int i = 0; int j = 0;

            while(i < A.Length && j < B.Length)
            {
                if((A[i] - B[j]) == target)
                {
                    return 1;
                }
                else if((A[i] - B[j]) > target)
                {
                    j++;
                }
                else
                {
                    i++;
                }
            }

            return -1;
        }
    }
}
