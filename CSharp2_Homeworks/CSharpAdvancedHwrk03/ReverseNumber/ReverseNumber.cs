using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            char[] numbers = Console.ReadLine().ToCharArray();            

            for (int i = numbers.Length-1; i > 0; i--)
            {
                Console.Write(numbers[i]);
            }
            Console.WriteLine(numbers[0]);
        }
    }
}
