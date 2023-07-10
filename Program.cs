using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    class DailyTemperatureRecord
    {
        public double HighestTemperature { get; set; }
        public double LowestTemperature { get; set; }
    }

    class Programa
    {
        static void Main()
        {
            DailyTemperatureRecord[] records = new DailyTemperatureRecord[]
            {
            new DailyTemperatureRecord { HighestTemperature = 25.5, LowestTemperature = 15.2 },
            new DailyTemperatureRecord { HighestTemperature = 30.1, LowestTemperature = 18.7 },
            new DailyTemperatureRecord { HighestTemperature = 28.6, LowestTemperature = 20.3 },
            new DailyTemperatureRecord { HighestTemperature = 24.8, LowestTemperature = 17.6 },
            };

            double maxDifference = double.MinValue;
            int maxDifferenceDay = -1;

            for (int i = 0; i < records.Length; i++)
            {
                double difference = records[i].HighestTemperature - records[i].LowestTemperature;
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                    maxDifferenceDay = i + 1;
                }
            }

            Console.WriteLine($"День з максимальною різницею між найвищою і найнижчою температурою: {maxDifferenceDay}");
        }
    }
}
