using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        public static bool IsPrime(int n)
        {
            int checker = 2;

            while ((checker < n) & (n % checker != 0))
            {
                checker++;
            }
            if (checker == n)
                return true;
            else
                return false;
        }



        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool result = false;
            while (!result)
            {
                result = IsPrime(n);
                n--;
            }
            Console.WriteLine(n + 1);
        }
    }
}

//Using Eratosthenes или който там беше... ;)

//using System;

//public class PrimeNumbers
//{
//    public static void Main()
//    {
//        int length = int.Parse(Console.ReadLine());

//        var isPrime = new byte[length + 1];
//        var result = 0;

//        for (int i = 2; i <= length; i++)
//        {
//            if (isPrime[i] == 0)
//            {
//                result = i;

//                for (int j = i * 2; j <= length; j += i)
//                {
//                    isPrime[j] = 1;
//                }
//            }
//        }

//        Console.WriteLine(result);
//    }
//}