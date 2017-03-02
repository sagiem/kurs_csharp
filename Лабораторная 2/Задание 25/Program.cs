using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_25
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, R;

            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = double.Parse(Console.ReadLine());

            R = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(c * Math.PI / 180));

            Console.WriteLine("{0:N4}", R);
        }
    }
}
