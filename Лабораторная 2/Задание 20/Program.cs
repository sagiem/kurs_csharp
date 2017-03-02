using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_20
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, v, h, R;
            double g = 9.8067;

            Console.WriteLine("Введите m");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите v");
            v = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите h");
            h = double.Parse(Console.ReadLine());

            R = ((m * v * v) / 2) * m * g * h;
            Console.WriteLine("{0:N4}", R);
        }
    }
}
