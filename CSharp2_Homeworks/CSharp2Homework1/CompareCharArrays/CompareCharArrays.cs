using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            
            char[] array1 = Console.ReadLine().ToCharArray();
            char[] array2 = Console.ReadLine().ToCharArray();
            string result = "=";

            if (array1.Length > array2.Length)
            {
                Console.WriteLine(">");
            }
            else if (array1.Length < array2.Length)
            {
                Console.WriteLine("<");
            }
            else
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] > array2[i])
                    {
                        result = ">";
                        break;
                    }
                    else if (array1[i] < array2[i])
                    {
                        result = "<";
                        break;
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
