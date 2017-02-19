using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double c;

            Console.WriteLine("Введите значение x");
            x = double.Parse(Console.ReadLine());
            c = 2 * x;
            Console.WriteLine(c);

        }
    }
}
