/*  10. Unicode characters
    Write a program that converts a string to a sequence of C# Unicode character literals.
    Input: On the only input line you will receive a string
    Output: Print the string in C# Unicode character literals on a single line
    Sample tests:
                    Input 	    Output
                    Hi! 	    \u0048\u0069\u0021
 */
namespace _10.UnicodeCharacters
{
    using System;
    using System.Text;
    class UnicodeCharacters
    {
        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }

        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();
            foreach (var character in input)
            {
                builder.Append(GetEscapeSequence(character));
            }

            string result = @builder.ToString();

            Console.WriteLine(result);
        }
    }
}
