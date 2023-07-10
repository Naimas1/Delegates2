using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    static class IntExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }
    }

    class Programf
    {
        static void Main()
        {
            int[] numbers = { 10, 15, 20, 25, 30 };

            foreach (int number in numbers)
            {
                bool isEven = number.IsEven();
                Console.WriteLine($"Число {number} є парним: {isEven}");
            }
        }
    }
}
