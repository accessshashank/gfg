using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gfg.Arrays
{
    class EquilibriumPoint
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 9, 1, 20, 32, 29, 5, 5 };
            int N = 7;
            Console.WriteLine(Equilibrium(arr, N));
        }

        static int Equilibrium(int[] arr, int N)
        {
            if (arr == null || arr.Length == 0) return -1;
            if (arr.Length == 1) return 1;

            var frontDict = new Dictionary<int, int>();
            var rearDict = new Dictionary<int, int>();

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                frontDict.Add(sum, i);
            }

            sum = 0;
            for (int i = arr.Length-1; i >= 0; i--)
            {
                sum += arr[i];
                rearDict.Add(sum, i);
            }

            foreach (var frontKey in frontDict.Keys)
            {
                if(rearDict.ContainsKey(frontKey) && rearDict[frontKey] > frontDict[frontKey] && Math.Abs(rearDict[frontKey]-frontDict[frontKey]) == 2)
                {
                    return (frontDict[frontKey] + 2);
                }
            }

            return -1;
        }
    }
}
