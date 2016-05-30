using System;
using System.Text;

namespace _05.ParseTags
{
    class ParseTags
    {       

        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder builder = new StringBuilder();

            var splitText = input.Split(new[] { "upcase>" }, StringSplitOptions.None);
            string toAppend = String.Empty;
            for (int i = 0; i < splitText.Length; i++)
            {
                toAppend = splitText[i].TrimEnd('<');
                builder.Append(toAppend);
                i++;
                if (i < splitText.Length)
                {
                    toAppend = splitText[i].TrimEnd("</".ToCharArray()).ToUpper();
                    builder.Append(toAppend);
                }
                else
                {
                    continue;
                }
                
            }
            string output = builder.ToString();
            Console.WriteLine(output);


        }
    }
}
