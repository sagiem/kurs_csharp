using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_30
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, R;

            Console.WriteLine("Введите a");
            a = (double.Parse(Console.ReadLine()))* Math.PI / 180;
            Console.WriteLine("Введите b");
            b = (double.Parse(Console.ReadLine()))* Math.PI / 180;

            R = Math.Sin(a) * Math.Cos(b) + Math.Cos(a) * Math.Sin(b);

            Console.WriteLine("{0:N4}", R);
        }
    }
}
