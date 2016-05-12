using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            long maxSum = arr.Min();
            long tempSum = 0;

            for (int i = 0; i < n; i++)
            {
                tempSum += arr[i];
                if (tempSum < 0)
                {
                    tempSum = 0;

                }
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                }

            }
            Console.WriteLine(maxSum);
        }
    }
}

