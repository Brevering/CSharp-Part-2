using System;
using System.Linq;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;

            for (int i = 1; i < n-1; i++)
            {
                if ((numbers[i] > numbers[i-1]) && (numbers[i] > numbers[i + 1]))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
