using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FU
{
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Created");
        }
        public abstract void Draw();
        public abstract double Area();
        public abstract double Perimetr();
    }

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ac;

        public Triangle(double ab, double bc, double ac)
        {
            this.ab = ab;
            this.bc = bc;
            this.ac = ac;

            Console.WriteLine("Triangle created");
        }
        public override double Area()
        {
            double s = (ab + bc) / 2;
            Console.WriteLine("");
            return Math.Sqrt(s * (s - ab) * (s - bc) * (s - ac));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Triangle");
        }

        public override double Perimetr()
        {
            return ab + ac + bc;
        }
    }

    public class Rectangle : Shape
    {
        private readonly double widght;
        private readonly double height;

        public Rectangle(double widght, double height)
        {
            this.widght = widght;
            this.height = height;

            Console.WriteLine("Rectangle created");
        }

        public override double Area()
        {
            return widght * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

        public override double Perimetr()
        {
            return 2 * (widght * height);
        }
    }
}
