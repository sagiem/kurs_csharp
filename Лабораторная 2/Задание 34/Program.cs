using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_34
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, R;

            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());

            R = 3 * (Math.Sin(2 * (a * Math.PI / 180))) * (Math.Cos(3 * (b * Math.PI / 180)));

            Console.WriteLine("{0:N4}", R);

        }
    }
}
