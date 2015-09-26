using System;
using System.Collections.Generic;
using System.Linq;
using Euclidean3D;

namespace Paths
{
    class Paths
    {
        static string loadPath = "../../Points.txt";
        static string savePath = "../../SavePoint.txt";

        static void Main()
        {
            //Euclidean3D.Point3D pointOne = new Euclidean3D.Point3D(0, 0, 0);
            //Euclidean3D.Point3D pointTwo = new Euclidean3D.Point3D(1, 2, 3);
            //Euclidean3D.Point3D pointTwo = new Euclidean3D.Point3D(0, 0, 0);
            
            Path3D path = new Path3D(Storage.PointExtraction(loadPath));
            Storage.SavePath(savePath, path);
            Console.WriteLine(path);
            
        }
    }
}
