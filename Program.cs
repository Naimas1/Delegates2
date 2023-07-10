using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    static class StringExtensions
    {
        public static int CountVowels(this string str)
        {
            int count = 0;

            foreach (char c in str.ToLower())
            {
                if (IsVowel(c))
                    count++;
            }

            return count;
        }

        private static bool IsVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }

    class Programdf
    {
        static void Main()
        {
            string[] strings = { "Hello", "World", "OpenAI", "Language" };

            foreach (string str in strings)
            {
                int vowelCount = str.CountVowels();
                Console.WriteLine($"Рядок '{str}' містить {vowelCount} голосних.");
            }
        }
    }
}
