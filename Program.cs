using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    static class PersonExtensions
    {
        public static double AverageAge(this Person[] people)
        {
            int totalAge = 0;

            foreach (var person in people)
            {
                totalAge += person.Age;
            }

            return (double)totalAge / people.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            Person[] people = {
            new Person { FirstName = "Andrei", LastName = "Mixailovich", Age = 30 },
            new Person { FirstName = "Marina", LastName = "Oleksandrivna", Age = 25 },
            new Person { FirstName = "Dima", LastName = "Anatolievich", Age = 35 },
            new Person { FirstName = "Bogdan", LastName = "Valerievich", Age = 40 }
        };

            Person youngestPerson = people.OrderBy(p => p.Age).First();
            Person oldestPerson = people.OrderByDescending(p => p.Age).First();

            Console.WriteLine("Молодша людина:");
            Console.WriteLine($"Ім'я: {youngestPerson.FirstName}");
            Console.WriteLine($"Прізвище: {youngestPerson.LastName}");
            Console.WriteLine($"Вік: {youngestPerson.Age}");

            Console.WriteLine();

            Console.WriteLine("Старша людина:");
            Console.WriteLine($"Ім'я: {oldestPerson.FirstName}");
            Console.WriteLine($"Прізвище: {oldestPerson.LastName}");
            Console.WriteLine($"Вік: {oldestPerson.Age}");

            Console.WriteLine();

            double averageAge = people.AverageAge();
            Console.WriteLine($"Середній вік: {averageAge}");
        }
    }
}
