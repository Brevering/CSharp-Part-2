using System;
using System.Linq;

namespace SumIntegers
{
    class Program
    {
        static public long sum(string inputstr)
        {
            int[] args = inputstr.Split(' ').Select(int.Parse).ToArray();
            long sum = 0;
            foreach (var item in args)
            {
                sum += item;
            }
            return sum;
        }


        static void Main()
        {
            string inputstr = Console.ReadLine();
            long result = sum(inputstr);
            Console.WriteLine(result);

        }
    }
}
