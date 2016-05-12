using System;

namespace Problem2
{
    class Problem2
    {
        static void Main()
        {
            int c = int.Parse(Console.ReadLine());
            int[] arr = new int[c + 1];
            int group1 = 1;
            int groupMax = 1;
            int j = 0;

            for (int i = 0; i < c; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            while (j < c)
            {
                group1 = 1;
                if (arr[j] < arr[j + 1])
                {
                    //start of group
                    while (arr[j] < arr[j + 1])
                    {
                        group1++;
                        arr[j + 1] = arr[j];
                        j++;
                    }
                    if (group1 > groupMax)
                    {
                        groupMax = group1;
                    }

                }
                else
                {

                    j++;

                }
            }

            Console.WriteLine(groupMax);

        }
    }
}
