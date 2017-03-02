using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double m, a, R;
            double g = 9.8067;

            Console.WriteLine("Введите m");
            m = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());

            R = m * g * Math.Sqrt(a * Math.PI / 180);
            Console.WriteLine("{0:N4}", R);

        }
    }
}
