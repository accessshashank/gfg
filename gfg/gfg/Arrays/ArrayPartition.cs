using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class ArrayPartition
    {
        static void Main(string[] args)
        {
            //https://practice.geeksforgeeks.org/problems/array-partition/1

            /*
             *  Given an array of N integers, you have to find if it is possible to partition the array with following rules:
                Each element should belong to exactly one partition.
                Each partition should have atleast K elements.
                Absolute difference between any pair of elements in the same partition should not exceed M.
             */
            int[] arr = new int[] { 22, 94, 94, 7, 4, 59, 26, 90, 88, 55 };
            int N = 10;
            int K = 2;
            int M = 22;
            Console.WriteLine(PartitionArrayV2(N, K, M, arr));
        }

        static bool PartitionArray(int N, int K, int M, int[] A)
        {

            if (A == null || A.Length == 0) return false;

            if (N < 2 * K) return false;

            Array.Sort(A); // 4,7,22,26,55,59,88,90,94,94

            for(int j = K; j < N-K; j++)
            {
                if ((A[j - 1] - A[0]) <= M && (A[N - 1] - A[j]) <= M) return true;
            }
            
            return false;
        }

        static bool PartitionArrayV2(int N, int K, int M, int[] A)
        {

            Array.Sort(A); // 4,7,22,26,55,59,88,90,94,94

            return Solve(0, N, K, M, A);
        }

        private static bool Solve(int cur, int n, int k, int m, int[] a)
        {
            if (cur >= n) return true;
            if (n - cur < k) return false;
            for (int i = cur+k-1; i < n; i++)
            {
                if (a[i] - a[cur] > m) return false;
                if (Solve(i + 1, n, k, m, a)) return true;
            }
            return false;
        }
    }
}
