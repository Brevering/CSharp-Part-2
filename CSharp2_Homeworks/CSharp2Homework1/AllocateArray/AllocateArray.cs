using System;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numarray = new int[n];
            for (int i = 0; i < n; i++)
            {
                numarray[i] = i * 5;
                Console.WriteLine(numarray[i]);
            }
            
        }
    }
}
