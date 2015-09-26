using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euclidean3D;


namespace Paths
{
    public class Path3D
    {
        private List<Point3D> points;

        public Path3D(List<Point3D> points)
        {
            this.Points = points;
        }

        public List<Point3D> Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public override string ToString()
        {
            string result = string.Format(string.Join("\n", Points ));
            return result;
        }
      //  List<Euclidean3D.Point3D> points = new  List<Euclidean3D.Point3D>(); 
        
    }
}
