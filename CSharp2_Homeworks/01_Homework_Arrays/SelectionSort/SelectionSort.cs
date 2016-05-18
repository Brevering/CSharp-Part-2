using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayN = new int[n];            
            for (int i = 0; i < n; i++)
            {
                arrayN[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int minValue = arrayN[i];
                int placeholder = 0;
                int index = 0;

                for (int j = i; j < n; j++)
                {
                    if (arrayN[j] <= minValue)
                    {
                        minValue = arrayN[j];
                        index = j;
                    }
                }
                placeholder = arrayN[index];
                arrayN[index] = arrayN[i];
                arrayN[i] = placeholder;
            }
            foreach (var item in arrayN)
            {
                Console.WriteLine(item);
            }
        }
    }
}
