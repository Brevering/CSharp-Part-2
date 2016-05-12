using System;
using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    class MergeSort
    {
        public static int[] SortIt(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            int mindex = array.Length / 2;
            int[] leftarr = new int[mindex];
            int[] rightarr = new int[array.Length - mindex];

            Array.Copy(array, leftarr, mindex);
            Array.Copy(array, mindex, rightarr, 0, array.Length - mindex);

            leftarr = SortIt(leftarr);
            rightarr = SortIt(rightarr);

            return Merge(leftarr, rightarr);
        }

        public static int[] Merge(int[] left, int[] right)
        {
            List<int> leftlist = left.ToList();
            List<int> rightlist = right.ToList();
            List<int> resultlist = new List<int>();

            while (leftlist.Count > 0 || rightlist.Count > 0)
            {
                if (leftlist.Count > 0 && rightlist.Count > 0)
                {
                    if (leftlist[0] <= rightlist[0])
                    {
                        resultlist.Add(leftlist[0]);
                        leftlist.RemoveAt(0);
                    }
                    else
                    {
                        resultlist.Add(rightlist[0]);
                        rightlist.RemoveAt(0);
                    }
                }
                else if (leftlist.Count > 0)
                {
                    resultlist.Add(leftlist[0]);
                    leftlist.RemoveAt(0);
                }
                else if (rightlist.Count > 0)
                {
                    resultlist.Add(rightlist[0]);
                    rightlist.RemoveAt(0);
                }
            }

            return resultlist.ToArray();
        }


        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrayN = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayN[i] = int.Parse(Console.ReadLine());
            }

            arrayN = SortIt(arrayN);

            foreach (var item in arrayN)
            {
                Console.WriteLine(item);
            }
        }
    }
}
