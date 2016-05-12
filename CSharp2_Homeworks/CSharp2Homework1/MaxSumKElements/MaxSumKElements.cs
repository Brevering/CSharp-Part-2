using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumKElements
{
    class MaxSumKElements
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long maxSum = 0;
            int[] arrayN = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayN[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arrayN);
            for (int i = n-k; i < n; i++)
            {
                maxSum += arrayN[i];
            }
            Console.WriteLine(maxSum);
        }
    }
}
