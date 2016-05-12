using System;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            int groupMax = 1;
            int group1 = 1;
            int frequentValue = arr[0];
            int j = 1;

            while (j < n)
            {
                group1 = 1;
                if (arr[j-1] == arr[j])
                {
                    //start of group
                    while ((j < n) && (arr[j-1] == arr[j]))
                    {
                        group1++;                        
                        j++;
                    }
                    if (group1 > groupMax)
                    {
                        groupMax = group1;
                        frequentValue = arr[j - 1];                        
                    }

                }
                
                else
                {

                    j++;

                }
            }
            Console.WriteLine("{0} ({1} times)", frequentValue, groupMax);
        }
    }
}


