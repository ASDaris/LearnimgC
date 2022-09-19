using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsRimNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RuleOfPars.Parse(Console.ReadLine()));
        }
    }
}