using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGeometry.ClassMathArea
{
    public class Circle : IMathArea
    {
        private double Redius;

        public double GetArea()
        {
            return 3.14 * Redius * Redius;
        }

        public double GetPerimetor()
        {
            return 2 * 3.14 * Redius;
        }
        public Circle(double redius)
        {
            Redius = redius;
        }
    }
}
