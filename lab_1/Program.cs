using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 1.97;
            double x = 0.7;
            double y = 0.0017;

            double M = Math.Exp(x / p) + 4.0 / 3.0 * Math.Asin(Math.Cos(x));

            Console.WriteLine("Исходные данные:");
            Console.WriteLine("p = " + p);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);

            Console.WriteLine("Результат:");
            Console.WriteLine("M = " + M);
        }
    }
}



