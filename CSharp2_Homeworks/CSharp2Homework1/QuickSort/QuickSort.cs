using System;
using System.Collections.Generic;

namespace QuickSort
{
    class QuickSort
    {
        //Pick a (random) pivot value. Remove it from the list
        //The rest of the values place those smaller in one list, 
        //those larger in another. Recurse.
        public static List<int> SortIt(List<int> arrayList)
        {
            List<int> lesser = new List<int>();
            List<int> greater = new List<int>();
            if (arrayList.Count <= 1)
            {
                return arrayList;
            }
            int position = 0;
            int pivot = arrayList[position];

            arrayList.RemoveAt(position);
            foreach (var x in arrayList)
            {
                if (x < pivot)
                {
                    lesser.Add(x);
                }
                else
                {
                    greater.Add(x);
                }
            }

            return Concat(SortIt(lesser), pivot, SortIt(greater));
        }

        //Join back the two sorted halves and the pivot in between
        public static List<int> Concat(List<int> lesser, int pivot, List<int> greater)
        {
            List<int> sorted = new List<int>(lesser);
            sorted.Add(pivot);
            foreach (var i in greater)
            {
                sorted.Add(i);
            }

            return sorted;
        }


        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayN = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayN[i] = int.Parse(Console.ReadLine());
            }
            List<int> arrL = new List<int>(arrayN);

            arrL = SortIt(arrL);

            foreach (var item in arrL)
            {
                Console.WriteLine(item);
            }
        }
    }
}
