using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_35
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, R;

            Console.WriteLine("Введите x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            x2 = double.Parse(Console.ReadLine());

            R = Math.Sqrt(x2 * x2 + x1 * x1);

            Console.WriteLine("{0:N4}", R);

        }
    }
}
