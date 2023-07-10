using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    static class IntExtensions
    {
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0;
        }
    }

    class Programd
    {
        static void Main()
        {
            int[] numbers = { 10, 15, 20, 25, 30 };

            foreach (int number in numbers)
            {
                bool isOdd = number.IsOdd();
                Console.WriteLine($"Число {number} є непарним: {isOdd}");
            }
        }
    }
}
