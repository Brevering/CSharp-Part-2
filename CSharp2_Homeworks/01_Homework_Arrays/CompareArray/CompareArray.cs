using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArray
{
    class CompareArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[n];
            bool x = true;
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                array2[j] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < n; k++)
            {
                if (array1[k] != array2[k])
                {
                    Console.WriteLine("Not equal");
                    x = false;
                    break;
                }
            }
            if (x)
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
