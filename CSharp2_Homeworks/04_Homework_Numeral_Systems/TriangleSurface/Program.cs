using System;

namespace TriangleSurface
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00}", (side * height) / 2);
        }
    }
}
