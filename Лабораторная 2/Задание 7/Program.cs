using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("введите значение A");
            a = double.Parse(Console.ReadLine());
            b = a * Math.PI / 180;
            Console.WriteLine("{0:N4}", b);
        }
    }
}
