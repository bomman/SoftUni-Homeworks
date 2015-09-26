using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    class Rhombs : BasicShape
    {
        private const short SidesOfRhombus = 4; 
        public Rhombs(double width, double height) : base(width, height)
        {
        }

        public override void CalculateArea()
        {
            double area = Height*Width;
            Console.Write("{0:F2}",area);
        }

        public override void CalculatePerimeter()
        {
            double perimeter = SidesOfRhombus*Width;
            Console.Write("{0:F2}", perimeter);
        }
    }
}
