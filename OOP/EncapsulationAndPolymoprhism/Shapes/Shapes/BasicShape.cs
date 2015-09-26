using System;
using Shapes.Interfaces;

namespace Shapes.Shapes
{
   abstract class BasicShape : IShape
   {
       private double width;
       private double height;

       public BasicShape(double width, double height)
       {
           this.Width = width;
           this.Height = height;
       }

       public double Width
       {
           get { return this.width; }
           set
           {
               if (value < 0)
               {
                   throw new ArgumentOutOfRangeException("Width", "Width cannot be a negative number!");
               }
               this.width = value;
           }
       }

       public double Height
       {
           get { return this.height; }
           set {
                   if (value < 0)
                   {
                       throw new ArgumentOutOfRangeException("Height", "Height cannot be a negative number!");
                   }
                   this.height = value;
               }
       }
       public abstract void CalculateArea();
       public abstract void CalculatePerimeter();

   }
}
