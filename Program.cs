using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    struct Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }
    }

    static class FractionExtensions
    {
        public static Fraction MinFraction(this Fraction[] fractions)
        {
            return fractions.OrderBy(f => (double)f.Numerator / f.Denominator).First();
        }

        public static Fraction MaxFraction(this Fraction[] fractions)
        {
            return fractions.OrderByDescending(f => (double)f.Numerator / f.Denominator).First();
        }
    }

    class Programfs
    {
        static void Main()
        {
            Fraction[] fractions = {
            new Fraction { Numerator = 1, Denominator = 2 },
            new Fraction { Numerator = 3, Denominator = 4 },
            new Fraction { Numerator = 1, Denominator = 3 },
            new Fraction { Numerator = 2, Denominator = 5 }
        };

            Fraction minFraction = fractions.MinFraction();
            Fraction maxFraction = fractions.MaxFraction();

            Console.WriteLine("Мінімальний дріб:");
            Console.WriteLine($"{minFraction.Numerator}/{minFraction.Denominator}");

            Console.WriteLine();

            Console.WriteLine("Максимальний дріб:");
            Console.WriteLine($"{maxFraction.Numerator}/{maxFraction.Denominator}");
        }
    }
}
