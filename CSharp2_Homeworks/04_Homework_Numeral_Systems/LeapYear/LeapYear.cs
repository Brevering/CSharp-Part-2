using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            int daysInFeb = System.DateTime.DaysInMonth(year, 2);
            if (daysInFeb == 29)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}
