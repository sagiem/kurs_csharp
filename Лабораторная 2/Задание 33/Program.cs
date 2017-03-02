using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_33
{
    class Program
    {
        static void Main(string[] args)
        {

            double h, t;
            double r = 6350;

            Console.WriteLine("Введите h");
            h = double.Parse(Console.ReadLine());

            t = Math.Sqrt(h * h + 2 * h * r);

            Console.WriteLine("{0:N4}", t);


        }
    }
}
