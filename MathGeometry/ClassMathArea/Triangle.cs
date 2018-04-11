using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGeometry.ClassMathArea
{
    class Triangle : IMathArea
    {
        private double Height;
        private double Wigth;

        public double GetArea()
        {
          return  0.5 * Height * Wigth;

        }

        public double GetPerimetor()
        {
            return Height + Wigth + (System.Math.Sqrt(Height * Height + Wigth * Wigth));
        }
        public Triangle(double height,double wigth)
        {
            Height = height;
            Wigth = wigth;

        }
    }
}
