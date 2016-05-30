using System;
using System.Text;

namespace _01.ReverseString
{
    class ReverseString
    {
        public static string ReverseStr(string input)
        {            
            StringBuilder builder = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                builder.Append(input[i]);
            }
            return builder.ToString();
        }

        static void Main()
        {
            string s = Console.ReadLine();
            string result = ReverseStr(s);
            Console.WriteLine(result);
        }
    }
}
