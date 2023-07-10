using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    static class StringExtensions
    {
        public static int CountSentences(this string str)
        {
            int count = 0;

            foreach (char c in str)
            {
                if (IsSentenceSeparator(c))
                    count++;
            }

            return count;
        }

        private static bool IsSentenceSeparator(char c)
        {
            return c == '.' || c == '?' || c == '!';
        }
    }

    class Programaf
    {
        static void Main()
        {
            string[] strings = {
            "Hello. How are you?",
            "I'm doing well. Thank you!",
            "This is a test sentence.",
            "No punctuation marks here"
        };

            foreach (string str in strings)
            {
                int sentenceCount = str.CountSentences();
                Console.WriteLine($"Рядок '{str}' містить {sentenceCount} пропозицій.");
            }
        }
    }
}
