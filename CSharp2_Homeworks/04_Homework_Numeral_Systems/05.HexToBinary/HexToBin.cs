using System;
using System.Collections.Generic;

namespace _05.HexToBinary
{
    class HexToBin
    {
        static Dictionary<char, string> HexBin = new Dictionary<char, string>()
        {
            {'0', "0000"},
            {'1', "0001"},
            {'2', "0010"},
            {'3', "0011"},
            {'4', "0100"},
            {'5', "0101"},
            {'6', "0110"},
            {'7', "0111"},
            {'8', "1000"},
            {'9', "1001"},
            {'A', "1010"},
            {'B', "1011"},
            {'C', "1100"},
            {'D', "1101"},
            {'E', "1110"},
            {'F', "1111"}
        };

        static string HexToBinary(string hex)
        {
            string[] result = new string[hex.Length];

            for (int i = 0; i < hex.Length; i++)
            {
                result[i] = HexBin[hex[i]];
            }

            return string.Join(string.Empty, result);
        }


        static void Main()
        {
            string input = Console.ReadLine();
            string output = HexToBinary(input);
            output = output.TrimStart('0');
            Console.WriteLine(output);
        }
    }
}
