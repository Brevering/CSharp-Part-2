using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int x = int.Parse(Console.ReadLine());
            int first = 0;
            int last = n - 1;
            int m = 0;
            int result = -1;
            Array.Sort(arr);

            while (first <= last)
            {
                m = (first + last) / 2;
                if (arr[m] < x)
                {
                    first = m + 1;
                }
                if (arr[m] > x)
                {
                    last = m - 1;
                    continue;
                }
                if (arr[m] == x)
                {
                    result = m;
                    break;
                }

            }
            Console.WriteLine(result);

        }
    }
}