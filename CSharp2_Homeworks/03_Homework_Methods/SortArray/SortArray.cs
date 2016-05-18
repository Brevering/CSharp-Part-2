using System;
using System.Linq;

namespace SortArray
{
    class SortArray
    {
        

         public static int[] SortIt(int[] inputArr, int length)
        {
            for (int i = 0; i < length; i++)
            {
                int minValue = inputArr[i];
                int placeholder = 0;
                int index = 0;

                for (int j = i; j < length; j++)
                {
                    if (inputArr[j] <= minValue)
                    {
                        minValue = inputArr[j];
                        index = j;
                    }
                }
                placeholder = inputArr[index];
                inputArr[index] = inputArr[i];
                inputArr[i] = placeholder;
            }
            return inputArr;

        }

        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            inputArr = SortIt(inputArr, length);
            Console.WriteLine(string.Join(" ", inputArr));

        }
    }
}
