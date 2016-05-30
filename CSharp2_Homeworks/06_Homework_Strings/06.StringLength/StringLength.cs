using System;
using System.Text;

namespace _06.StringLength
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            input = input.Replace(@"\", string.Empty);
            StringBuilder builder = new StringBuilder();
            builder.Append(input);
            for (int i = 0; i < 20 - input.Length; i++)
            {
                builder.Append('*');
            }

            Console.WriteLine(builder.ToString());

            // you can use PadRight as well for shorter code
            //string text = Console.ReadLine();
            //text = text.Replace(@"\", string.Empty);
            //Console.WriteLine(text.PadRight(20, '*'));

        }
    }
}
