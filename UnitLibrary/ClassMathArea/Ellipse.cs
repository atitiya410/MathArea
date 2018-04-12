using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGeometry.ClassMathArea
{
    public class Ellipse : IMathArea
    {
        private double RediusX;
        private double RediusY;


        public double GetArea()
        {
            return 3.14 * RediusX*RediusY; 
        }

        public double GetPerimetor()
        {
            return 3.14 * (RediusX + RediusY);
        }
        public Ellipse(double rediusx, double rediusy)
        {
            RediusX = rediusx;
            RediusY = rediusy;
        }
    }
}
