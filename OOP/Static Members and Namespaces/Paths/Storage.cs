using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
using Euclidean3D;

namespace Paths
{
             
   public static class Storage
    {
        
        public static List<Point3D> PointExtraction(string path) // This method fills the list in Path3D class with points from a text file.
        {
            Regex regex = new Regex(@"(\d+),\s?(\d+),\s?(\d+)|[A-Za-z]:\s?(\d+)[^a-zA-Z]+?[a-zA-Z]:\s?(\d+)[^a-zA-Z]+?[a-zA-Z]:\s?(\d+)"); // regex for taking the points from a text file
            List<Euclidean3D.Point3D> points = new List<Point3D>();
            string file = File.ReadAllText(path);
            foreach (Match match in regex.Matches(file))
            {
                double pointX = new double();
                double pointY = new double();
                double pointZ = new double();

                try
                {

                    if (match.Groups[1].Value != string.Empty)
                    {
                        pointX = double.Parse(match.Groups[1].Value);
                        pointY = double.Parse(match.Groups[2].Value);
                        pointZ = double.Parse(match.Groups[3].Value);
                        
                    }
                    else
                    {
                        pointX = double.Parse(match.Groups[4].Value);
                        pointY = double.Parse(match.Groups[5].Value);
                        pointZ = double.Parse(match.Groups[6].Value);
                        
                    }
                    Euclidean3D.Point3D point = new Euclidean3D.Point3D(pointX, pointY, pointZ);
                    points.Add(point);
                }
                catch(FormatException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
               

            }
            return points;
        }

       public static void SavePath(string destiation, Path3D path)
        {
            foreach (var point in path.Points)
            {
                File.AppendAllText(destiation, point.ToString());
            }
        }
    }
}
