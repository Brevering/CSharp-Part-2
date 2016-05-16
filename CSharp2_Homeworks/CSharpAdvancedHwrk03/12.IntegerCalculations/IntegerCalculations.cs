using System;
using System.Linq;

namespace _12.IntegerCalculations
{
    class IntegerCalculations
    {

        static public int minimum(params int[] args)
        {
            int minimum = args[0];

            foreach (var item in args)
            {
                if (item < minimum)
                {
                    minimum = item;
                }
            }

            return minimum;
        }

        static public int maximum(params int[] args)
        {
            int maximum = args[0];

            foreach (var item in args)
            {
                if (item > maximum)
                {
                    maximum = item;
                }
            }

            return maximum;
        }

        static public long sum(params int[] args)
        {
            long sum = 0;
            foreach (var item in args)
            {                
                    sum += item;
            }
            return sum;
        }

        static public decimal average(params int[] args)
        {
            decimal members = args.Length;
            decimal average = sum(args) / members;         
            return average;
        }

        static public long product(params int[] args)
        {
            long product = 1;
            foreach (var item in args)
            {
                product *= item;
            }
            return product;
        }



        static void Main()
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(minimum(arr));
            Console.WriteLine(maximum(arr));
            Console.WriteLine("{0:0.00}", average(arr));
            Console.WriteLine(sum(arr));
            Console.WriteLine(product(arr));
        }
    }
}
