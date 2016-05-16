using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastEnglish
{
    class LastEnglish
    {

        public static string EnWord (int inputint)
        {
            inputint = inputint % 10;
            string outputstring = "";
            switch (inputint)
            {
                case 0: outputstring = "zero"; break;
                case 1: outputstring = "one"; break;
                case 2: outputstring = "two"; break;
                case 3: outputstring = "three"; break;
                case 4: outputstring = "four"; break;
                case 5: outputstring = "five"; break;
                case 6: outputstring = "six"; break;
                case 7: outputstring = "seven"; break;
                case 8: outputstring = "eight"; break;
                case 9: outputstring = "nine"; break;
                default:
                    break;
            }
            return outputstring;
        }


        static void Main()
        {
            int inputint = int.Parse(Console.ReadLine());
            Console.WriteLine(EnWord(inputint));
        }
    }
}
