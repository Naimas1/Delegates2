using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    public static class StringExtensions
    {
        public static bool AreBracketsValid(this string text)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in text)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();

                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }

    class Programo
    {
        static void Main()
        {
            string[] texts = { "{}[]", "(())", "[{}]", "[}", "[[{]}]" };

            foreach (string text in texts)
            {
                bool isValid = text.AreBracketsValid();
                Console.WriteLine($"Рядок: '{text}', Валідність дужок: {isValid}");
            }
        }
    }
}
