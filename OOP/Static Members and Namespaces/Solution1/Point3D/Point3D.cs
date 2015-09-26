using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidean3D

{
    // This project includes problem 1 - 3D Point in Euclidean space and problem 2 - calculating a distance between 2 3D points.
    class Point
    {
        static void Main()
        {
            Point3D pointOne = new Point3D(0, 0, 0);
            Point3D pointTwo = new Point3D(1, 2, 3);
            Console.WriteLine("PROBLEM ONE: ");
            Console.WriteLine("First point coordinates: ");
            Console.WriteLine(pointOne);
            Console.WriteLine("Second point coordinates: ");
            Console.WriteLine(pointTwo);
            Console.WriteLine("---------------------");
            Console.WriteLine("PROBLEM TWO: ");
            Console.WriteLine("Distance between the two points: ");
            double distance = DistanceCalculator.DistanceBetween3DPointsCalculator(pointOne, pointTwo);
            Console.WriteLine(distance);
        }
    }
}
