/*  8. Extract sentences
    Write a program that extracts from a given text all sentences containing given word.
    Input:
        On the first line you will receive a string - the word
        On the second line you will receive a string - the text
    Output: Print only the sentences containing the word on a single line
    Constraints: Sentences are separated by . and the words – by non-letter symbols
    Sample tests
    Input 	
    in
    We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
    Output
    We are living in a yellow submarine. We will move out of it in 5 days.
 */

using System;
using System.Linq;
using System.Text;

class ExtractSentences
{
    private static char[] GetNonLetterSymbols(string input)
    {
        char[] symbols = input
            .Where(ch => !char.IsLetter(ch))
            .Distinct() // removes all duplicate elements in a collection; returns only the distinct elements
            .ToArray();

        return symbols;
    }

    static void Main()
    {
        var word = Console.ReadLine();
        var text = Console.ReadLine();
        var sentences = text.Split('.');
        var nonLetters = GetNonLetterSymbols(text);

        var result = new StringBuilder();

        foreach (var sentence in sentences)
        {
            var words = sentence.Split(nonLetters, StringSplitOptions.RemoveEmptyEntries);

            if (Array.IndexOf(words, word) > -1)
            {
                result.Append(sentence.Trim());
                result.Append(". ");
            }
        }

        Console.WriteLine(result.ToString().Trim());
    }
}