using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    static class IntExtensions
    {
        public static bool IsPrime(this int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }

    class Programad
    {
        static void Main()
        {
            int[] numbers = { 10, 13, 20, 23, 30 };

            foreach (int number in numbers)
            {
                bool isPrime = number.IsPrime();
                Console.WriteLine($"Число {number} є простим: {isPrime}");
            }
        }
    }
}
