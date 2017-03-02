using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_31
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());

            y = 7 * x * x - 3 * x + 6;

            Console.WriteLine(y);
        }
    }
}
