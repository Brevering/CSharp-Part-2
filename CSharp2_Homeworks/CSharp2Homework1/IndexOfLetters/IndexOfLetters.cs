using System;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var chars = input.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]-97);
            }
        }
    }
}
