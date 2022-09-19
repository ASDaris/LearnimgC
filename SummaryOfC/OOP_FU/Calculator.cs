using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_FU
{
    public class Calculator
    {
        public bool TryDivide(double divisible, double divisor, out double result)
        {
            result = 0;
            if(divisor == 0)
            {
                return false;
            }
            result = divisible / divisor;
            return true;
        }
        public static double Average(int[] numbers)
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum/numbers.Length;

        }
        public static double Average2(params int[] numbers) //params is the last argument
        {
            double sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
            }
            return sum / numbers.Length;
        }
        public static double CalcTriangSquare(double at, double bt, double ct)
        {
            double p = (at + bt + ct) / 2;
            return Math.Sqrt((p * (at + p) * (bt + p) * (ct + p)));
        }
        public static double CalcTriangSquare(double b, double h)
        {
            return 0.5 * b * h;
        }
        public static double CalcTriangSquare(double ab, double ac, int sin, bool isInRadians = false) //bool isInRadians = false is optional parametres, must come last, must have compile constant
        {                                                                                              //not supported by some .net codes, not public api friendly
            if (isInRadians)
            {
                return 0.5 * ab * ac * Math.Sin(sin);
            }
            else
            {
                double rads = sin * Math.PI / 180;
                return 0.5 * ab * ac * Math.Sin(rads);
            }

        }

    }
}
