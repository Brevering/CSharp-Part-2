using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DecimalToBinary
{
    class DecimalToBinary
    {

        public static string DecToBin(long decnum)
        {
            List<byte> result = new List<byte>();
            while (decnum >0)
            {
                result.Add((byte)(decnum % 2));
                decnum /= 2;
            }
            result.Reverse();

            StringBuilder builder = new StringBuilder();
            foreach (var item in result)
            {
                builder.Append(item);
            }
            string res = builder.ToString();
            return res;
        }


        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            string a = DecToBin(input);
            Console.WriteLine(a);
        }
    }
}
