using System;


namespace TriangleTwoSidesAngle
{
    class TriangleTwoSidesAngle
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double alpha = double.Parse(Console.ReadLine());

            double area = (a * b * Math.Sin(Math.PI * alpha / 180)) / 2;

            Console.WriteLine("{0:0.00}", area);
        }
    }
}
