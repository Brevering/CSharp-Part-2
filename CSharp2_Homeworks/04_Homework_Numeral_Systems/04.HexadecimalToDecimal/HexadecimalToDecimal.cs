using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.HexadecimalToDecimal
{
    class HexadecimalToDecimal
    {
        const string HexDigits = "0123456789ABCDEF";

        static int HexDigitToDecimalValue(char hexDigit)
        {
            if (char.IsDigit(hexDigit))
            {
                return hexDigit - '0';
            }

            return char.ToUpper(hexDigit) - 'A' + 10;
        }

        public static long HexToDec(string input)
        {
            long sum = 0;

            foreach (char hex in input)
            {


                sum = HexDigitToDecimalValue(hex) + sum * 16;
            }

            return sum;
        }


        static void Main()
        {
            string inputStr = Console.ReadLine();
            long decNum = HexToDec(inputStr);
            Console.WriteLine(decNum);
        }
    }
}
