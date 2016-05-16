using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMax
{
    class GetMax
    {

        static public int Evaluate(int a, int b)
        {
            if (a >= b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main()
        {
            int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int a = dimentions[0];
            int b = dimentions[1];
            int c = dimentions[2];
            int output = 0;

            output = Evaluate(c, Evaluate(a, b));
            Console.WriteLine(output);
        }
    }
}
