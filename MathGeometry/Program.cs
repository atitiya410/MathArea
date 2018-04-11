using MathGeometry.ClassMathArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGeometry
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(20, 40);
            Rectangle rg = new Rectangle(7,11);
            Square sq = new Square(10);
            Ellipse el = new Ellipse(10, 20);
            Circle cc = new Circle(10);

            Console.WriteLine("Triangle of GetArea : " + tr.GetArea());
            Console.WriteLine("Triangle of GetPerimetor : " + tr.GetPerimetor());
            Console.WriteLine("");
            Console.WriteLine("Rectangle of GetArea : " + rg.GetArea());
            Console.WriteLine("Rectangle of GetPerimetor : " + rg.GetPerimetor());
            Console.WriteLine("");
            Console.WriteLine("Square of GetArea : " + sq.GetArea());
            Console.WriteLine("Square of GetPerimetor : "+ sq.GetPerimetor());
            Console.WriteLine("");
            Console.WriteLine("Ellipse of GetArea : " + el.GetArea());
            Console.WriteLine("Ellipse of GetPerimetor : " + el.GetPerimetor());
            Console.WriteLine("");
            Console.WriteLine("Circle of GetArea : " + cc.GetArea());
            Console.WriteLine("Circle of GetPerimetor : " + cc.GetPerimetor());



            Console.ReadLine();
        }
    }
}
