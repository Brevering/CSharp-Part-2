using System;
using System.Linq;

namespace MaximumSum
{
    class MaximumSum
    {
        static void Main()
        {
            string[] dimensions = Console.ReadLine().Split(' ');

            int[][] matrix = new int[int.Parse(dimensions[0])][]; //create array of n arrays
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                matrix[x] = Console.ReadLine()
                                         .Trim(' ')
                                         .Split(' ')
                                         .Select(num => int.Parse(num))
                                         .ToArray();
            }

            int maxsum = int.MinValue;
            int tempsum = 0;

            for (int i = 0; i < matrix.GetLength(0)-2; i++)
            {
                for (int j = 0; j < matrix[0].GetLength(0) - 2; j++)
                {
                    tempsum = 0;
                    for (int r = i; r < i+3; r++)
                    {
                        for (int c = j; c < j+3; c++)
                        {
                            tempsum += matrix[r][c];
                        }
                    }
                    if (tempsum >= maxsum)
                    {
                        maxsum = tempsum;
                    }
                }
            }           
            Console.WriteLine(maxsum);
        }
    }
}