using System;
using Shapes.Interfaces;

namespace Shapes.Shapes
{
    class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Radius",
                        "Radius of the circle cannot be a negative number!");
                }
                this.radius = value;
            }
        }
        public void CalculateArea()
        {
            double area = Math.PI * (radius * radius);
            Console.Write("{0:F2}", area);
        }

        public void CalculatePerimeter()
        {
            double perimeter = 2 * (Math.PI * radius);
            Console.Write("{0:F2}", perimeter);
        }
    }
}
