using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    static class StringExtensions
    {
        public static int LengthOfLastWord(this string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (words.Length > 0)
            {
                return words[words.Length - 1].Length;
            }
            return 0;
        }
    }

    class Programi
    {
        static void Main()
        {
            string[] texts = { "Hello, world!", "Programming is fun", "  ", "OpenAI ChatGPT" };

            foreach (string text in texts)
            {
                int length = text.LengthOfLastWord();
                Console.WriteLine($"Рядок: '{text}', Довжина останнього слова: {length}");
            }
        }
    }
}
