using System;

namespace Maximal_Sequence
{
    class Maximal_Sequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n + 1];
            int group1 = 1;
            int groupMax = 1;
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            while (counter < n)
            {
                group1 = 1;
                if (arr[counter] == arr[counter + 1])
                {
                    //start of group
                    while (arr[counter] == arr[counter + 1])
                    {
                        group1++;
                        counter++;
                    }
                    if (group1 > groupMax)
                    {
                        groupMax = group1;
                    }

                }
                else
                {

                    counter++;

                }
            }
            Console.WriteLine(groupMax);
        }
    }
}
