using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_HomeworkOOP
{
    public class Complex
    {
        public double RealNumb { get; private set; }
        public double ImagNumb { get; private set; }
        public Complex(double realNumb, double imagNumb)
        {
            RealNumb = realNumb;
            ImagNumb = imagNumb;
        }

        private Complex()
        {

        }

        public Complex Plus(Complex other)
        {
            var complex = new Complex();
            complex.ImagNumb = other.ImagNumb + ImagNumb;
            complex.RealNumb = other.RealNumb + RealNumb;
            return complex;
        }
        public Complex Minus(Complex other)
        {
            var complex = new Complex();
            complex.ImagNumb = other.ImagNumb - ImagNumb;
            complex.RealNumb = other.RealNumb - RealNumb;
            return complex;
        }
        public void Answer()
        {
            Console.WriteLine($"{RealNumb}, {ImagNumb}");
        }
    }

}
