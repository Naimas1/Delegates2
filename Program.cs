using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    static class ArrayExtensions
    {
        public static int[] Filter(this int[] array, Func<int, bool> predicate)
        {
            int[] filteredArray = Array.FindAll(array, predicate);
            return filteredArray;
        }
    }

    class Programp
    {
        static void Main()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int[] filteredNumbers = numbers.Filter(num => num % 2 == 0);

            Console.WriteLine("Парні числа:");
            foreach (int num in filteredNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
