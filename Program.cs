using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
    }

    class Programsg
    {
        static double CalculateDistance(Point3D point1, Point3D point2)
        {
            double deltaX = point2.X - point1.X;
            double deltaY = point2.Y - point1.Y;
            double deltaZ = point2.Z - point1.Z;

            double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);

            return distance;
        }

        static void Main()
        {
            Point3D[] points = {
            new Point3D { X = 1, Y = 2, Z = 3 },
            new Point3D { X = 4, Y = 5, Z = 6 },
            new Point3D { X = -2, Y = 0, Z = 7 },
            new Point3D { X = 10, Y = -5, Z = 2 }
        };

            double maxDistance = 0;
            Point3D pointA = null;
            Point3D pointB = null;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = CalculateDistance(points[i], points[j]);

                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        pointA = points[i];
                        pointB = points[j];
                    }
                }
            }

            Console.WriteLine("Максимальна відстань між точками:");
            Console.WriteLine($"Точка A: ({pointA.X}, {pointA.Y}, {pointA.Z})");
            Console.WriteLine($"Точка B: ({pointB.X}, {pointB.Y}, {pointB.Z})");
            Console.WriteLine($"Відстань: {maxDistance}");
        }
    }
}
