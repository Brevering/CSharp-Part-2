using System;
using System.Collections.Generic;

namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        static List<int> FindOccurrences(string text, char character)
        {
            var indices = new List<int>();

            int indexOfNextBacon = text.IndexOf(character);

            while (indexOfNextBacon != -1)
            {
                indices.Add(indexOfNextBacon);
                indexOfNextBacon = text.IndexOf(character, indexOfNextBacon + 1);
            }

            return indices;
        }


        static void Main()
        {
            string input = Console.ReadLine();
            List<int> listOpening = FindOccurrences(input, '(');
            List<int> listClosing = FindOccurrences(input, ')');
            string output = string.Empty;

            if ((input.Length < 2) || 
                (listOpening.Count != listClosing.Count) ||
                (listOpening[0] > listClosing[0]))
            {
                output = "Incorrect";
            }
            else
            {
                output = "Correct";
            }

            Console.WriteLine(output);
        }
    }
}
