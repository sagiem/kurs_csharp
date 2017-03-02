using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_28
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, R;

            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());

            if (a < 0 || a == 0 && b == 0 && c == 0 && x == 0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            R = 1 / (Math.Sqrt(a * x * x + b * x + c));
            Console.WriteLine("{0:N4}", R);


        }
    }
}
