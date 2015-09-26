using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidean3D
{
    static class DistanceCalculator
    {
        // Problem 2 Distance Calculator
       public static double DistanceBetween3DPointsCalculator(Point3D pointOne, Point3D pointTwo)
        {
            double distance = Math.Sqrt((
                (pointOne.PointX - pointTwo.PointX) * (pointOne.PointX - pointTwo.PointX)) +
                ((pointOne.PointY - pointTwo.PointY) * (pointOne.PointY - pointTwo.PointY)) +
                ((pointOne.PointZ - pointOne.PointZ) * (pointOne.PointZ - pointOne.PointZ)));
            return distance;
        }

        
    }
}
