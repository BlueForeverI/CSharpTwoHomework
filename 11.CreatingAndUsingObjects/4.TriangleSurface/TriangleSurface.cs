using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4.TriangleSurface
{
    class TriangleSurface
    {
        static double GetSurfaceBySideAndAltitude(double side, double altitude)
        {
            return (side*altitude)/2;
        }

        static double GetSurfaceByThreeSides(double a, double b, double c)
        {
            double p = (a + b + c)/2;
            return Math.Sqrt(p*(p - a)*(p - b)*(p - c));
        }

        static double GetSurfaceByTwoSidesAndAngle(double side1, double side2, double angle)
        {
            double angleInRadians = Math.PI * angle / 180.0;
            return (side1 * side2 * Math.Sin(angleInRadians)) / 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetSurfaceBySideAndAltitude(5, 4));
            Console.WriteLine(GetSurfaceByThreeSides(3, 4, 5));
            Console.WriteLine(GetSurfaceByTwoSidesAndAngle(20, 20, 60));
        }
    }
}
