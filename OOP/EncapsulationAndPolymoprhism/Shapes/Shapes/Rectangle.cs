using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    class Rectangle : BasicShape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
        }

        public override void CalculateArea()
        {
            double area = Height*Width;
            Console.Write("{0:F2}", area);
        }

        public override void CalculatePerimeter()
        {
            double perimeter = 2*(Width + Height);
            Console.Write("{0:F2}", perimeter);
        }
    }
}
