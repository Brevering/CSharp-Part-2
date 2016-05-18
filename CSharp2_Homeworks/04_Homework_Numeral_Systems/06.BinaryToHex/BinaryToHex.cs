using System;
using System.Collections.Generic;

namespace _06.BinaryToHex
{
    class BinaryToHex
    {
        static Dictionary<string, string> BinHex = new Dictionary<string, string>()
        {
            {"0000", "0"},
            {"0001", "1"},
            {"0010", "2"},
            {"0011", "3"},
            {"0100", "4"},
            {"0101", "5"},
            {"0110", "6"},
            {"0111", "7"},
            {"1000", "8"},
            {"1001", "9"},
            {"1010", "A"},
            {"1011", "B"},
            {"1100", "C"},
            {"1101", "D"},
            {"1110", "E"},
            {"1111", "F"}
        };
        public static string TrimStr (string input)

        {
            string a = input;
            a = a.Remove(a.Length - 4);
            return a;
        }



        static void Main()
        {
            string binInput = Console.ReadLine();
            int padNeeded = 4 - (binInput.Length % 4);
            binInput = binInput.PadLeft((binInput.Length + padNeeded), '0');
            string result = string.Empty;
            string dummy = string.Empty;
            for (int i = 0; i < binInput.Length; i+=4)
            {
                dummy = binInput.Substring(i, 4);
                result += BinHex[dummy];
            }

            result = result.TrimStart('0');
            Console.WriteLine(result);
        }
    }
}
