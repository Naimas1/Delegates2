using Delegates2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    static class NumberExtensions
    {
        public static bool IsFibonacciNumber(this int number)
        {

            int a = 0;
            int b = 1;

            while (b < number)
            {
                int temp = b;
                b = a + b;
                a = temp;
            }

            return b == number;
        }
    }

    class Programu
    {
        static void Main()
        {
            int[] numbers = { 0, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

            foreach (int number in numbers)
            {
                bool isFibonacci = number.IsFibonacciNumber();
                Console.WriteLine($"{number} є числом Фібоначчі: {isFibonacci}");
            }
        }
    }
}
