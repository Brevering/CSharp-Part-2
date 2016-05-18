using System;

namespace _02.BinaryToDecimal
{
    class BinaryToDecimal
    {
        public static long BinToDec (string input)
        {
            long sum = 0;

            foreach (char bit in input)
            {
                sum = (bit - '0') + sum * 2;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            string inputStr = Console.ReadLine();
            long decNum = BinToDec(inputStr);
            Console.WriteLine(decNum);
        }
    }
}
