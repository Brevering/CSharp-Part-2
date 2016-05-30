using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SubstringInText
{
    class SubstringInText
    {
        static List<int> FindOccurrences(string text, string word)
        {
            var indices = new List<int>();

            int indexOfNextBacon = text.IndexOf(word);

            while (indexOfNextBacon != -1)
            {
                indices.Add(indexOfNextBacon);
                indexOfNextBacon = text.IndexOf(word, indexOfNextBacon + 1);
            }

            return indices;
        }


        static void Main()
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();
            string editedPattern = pattern.ToLower();
            string editedText = text.ToLower();

            List<int> occurences = FindOccurrences(editedText, editedPattern);
            if (occurences[0] == -1)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(occurences.Count());
            }

        }
    }
}
