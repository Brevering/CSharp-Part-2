using System;
using System.Linq;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] == x)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
