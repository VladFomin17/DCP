using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpt4
{
    public class Rectangle : Shape
    {
        public double Height;
        public double Width;

        public Rectangle(double height, double width)
        {
            Height = height; 
            Width = width;
        }

        public override double GetArea()
        {
            return Height * Width;
        }
    }
}
