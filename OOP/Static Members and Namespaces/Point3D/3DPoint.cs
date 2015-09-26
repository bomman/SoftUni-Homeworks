using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidean3D
{
    public class Point3D
    {
        static readonly Point3D startingPoint = new Point3D(0, 0, 0);
        

        public Point3D(double X, double Y, double Z)
        {
            this.PointX = X;
            this.PointY = Y;
            this.PointZ = Z;
        }

        public double PointX
        {
            get;
            set;
        }

        public double PointY
        {
            get;
            set;
        }
        public double PointZ
        {
            get;
            set;
        }
        public static Point3D StartingPoint
        {
            get { return startingPoint; }
        }
        public override string ToString()
        {
            string result = string.Format("Point coordinates:\nX: {0}\nY: {1}\nZ: {2}\n", this.PointX, this.PointY, this.PointZ);
            return result;
        }
    }
}
