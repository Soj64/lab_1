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
            double x = 0.7;

            double M = Math.Exp(x / Math.PI) + 4.0 / 3.0 * Math.Asin(Math.Cos(x));

            Console.WriteLine("Исходные данные:");
            Console.WriteLine("x = " + x);

            Console.WriteLine("Результат:");
            Console.WriteLine("M = " + M);
        }
    }
}



