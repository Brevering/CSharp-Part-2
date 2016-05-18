using System;

namespace SayHello
{
    class Program
    {
        static public string SayHello (string input)
            {
            string output = "Hello, ";
            output += input;
            output += "!";
            return output;
        }

        static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine(SayHello(name));
        }
    }
}
