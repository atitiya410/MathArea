using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGeometry.ClassMathArea
{
    public class Rectangle : IMathArea
    {
        private double Height;
        private double Wigth;

        public double GetArea()
        {
            return Height * Wigth;
        }

        public double GetPerimetor()
        {
            return 2*Height + 2*Wigth;
        }
        public Rectangle(double height1, double wigth1)
        {
            Height = height1;
            Wigth = wigth1;

        }
    }
}
