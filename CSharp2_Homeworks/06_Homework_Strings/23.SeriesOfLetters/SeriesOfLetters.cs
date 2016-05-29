/*  23. Series of letters
    Write a program that reads a string from the console and 
    replaces all series of consecutive identical letters with a single one.
    Input: On the only input line you will receive a string
    Output: Print the string without consecutive identical letters
    Sample tests: 
                        Input 	                    Output
                        aaaaabbbbbcdddeeeedssaa 	abcdedsa
 */
namespace _23.SeriesOfLetters
{
    using System;
    using System.Text;

    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            builder.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    builder.Append(input[i]);
                }               
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
