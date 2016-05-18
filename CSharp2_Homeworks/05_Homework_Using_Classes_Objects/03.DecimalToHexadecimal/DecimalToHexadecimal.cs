using System;

namespace _03.DecimalToHexadecimal
{
    class DecimalToHexadecimal
    {
        const string HexDigits = "0123456789ABCDEF";


        public static string DecToHex(long input)
        {
            string result = string.Empty;

            do
            {
                long value = input % 16;
                result = HexDigits[(int)value] + result;
                input /= 16;

            } while (input != 0);

            return result;
        }
        
        static void Main()
        {
            long decNum = long.Parse(Console.ReadLine());
            string hexNum = DecToHex(decNum);
            Console.WriteLine(hexNum);
        }
    }
}
