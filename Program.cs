using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    class StudentGradesRecord
    {
        public string StudentName { get; set; }
        public int[] Grades { get; set; }

        public double GetMaxGrade()
        {
            if (Grades.Length == 0)
                return 0;

            int maxGrade = Grades[0];

            for (int i = 1; i < Grades.Length; i++)
            {
                if (Grades[i] > maxGrade)
                    maxGrade = Grades[i];
            }

            return maxGrade;
        }

        public double GetAverageGrade()
        {
            if (Grades.Length == 0)
                return 0;

            int sum = 0;

            foreach (int grade in Grades)
            {
                sum += grade;
            }

            return (double)sum / Grades.Length;
        }
    }

    class Programs
    {
        static void Main()
        {
            StudentGradesRecord[] students = new StudentGradesRecord[]
            {
            new StudentGradesRecord { StudentName = "John", Grades = new int[] { 80, 90, 75, 85 } },
            new StudentGradesRecord { StudentName = "Emily", Grades = new int[] { 95, 87, 92, 88 } },
            new StudentGradesRecord { StudentName = "Michael", Grades = new int[] { 70, 82, 78, 65 } },
            };

            double maxAverageGrade = double.MinValue;
            string studentWithMaxAverageGrade = "";

            foreach (StudentGradesRecord student in students)
            {
                double averageGrade = student.GetAverageGrade();

                if (averageGrade > maxAverageGrade)
                {
                    maxAverageGrade = averageGrade;
                    studentWithMaxAverageGrade = student.StudentName;
                }
            }

            Console.WriteLine($"Студент з максимальною середньою оцінкою: {studentWithMaxAverageGrade}");
        }
    }
}
