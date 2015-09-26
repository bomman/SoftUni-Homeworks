using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes.Interfaces;
using Shapes.Shapes;

namespace Shapes
{
    class Shape
    {
        static void Main()
        {
            
            List<IShape> shapes = new List<IShape>()
            {
                new Circle(4.5),
                new Rectangle(5.6, 5),
                new Rhombs(4.1,16)
            };

            foreach (var shape in shapes)
            {
                Console.Write("Area of the {0}: ", shape.GetType().Name);
               shape.CalculateArea();
                Console.WriteLine();
               Console.Write("Perimeter of the {0}: ", shape.GetType().Name);
               shape.CalculatePerimeter();
                Console.WriteLine();
            }
        }
    }
}
