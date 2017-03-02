using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_18
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, R;
            Console.WriteLine("Введите значение x1");
            x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение x2");
            x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение x3");
            x3 = double.Parse(Console.ReadLine());

            R = x1 * x2 + x1 * x3 + x2 * x3;
            Console.WriteLine(R);
        }
    }
}
