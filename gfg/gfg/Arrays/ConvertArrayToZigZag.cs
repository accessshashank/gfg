using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class ConvertArrayToZigZag
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 3, 2 };
            int n = 4;
            Traverse(arr, n);
            Console.WriteLine(string.Join(",", arr));
        }

        private static void Traverse(int[] arr, int n)
        {
            for(int i=0; i< n;i++)
            {
                if (i == n - 1) return;

                if(i%2 == 0)
                {
                    if(arr[i] > arr[i+1])
                    {
                        swap(arr, i, i + 1);
                    }
                }
                else
                {
                    if(arr[i] < arr[i+1])
                    {
                        swap(arr, i, i + 1);
                    }
                }
            }
        }

        private static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
