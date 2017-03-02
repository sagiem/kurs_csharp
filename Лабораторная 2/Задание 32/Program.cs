using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_32
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;

            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());

            b=12*a*a+7*a-16;

            Console.WriteLine("{0:N4}", b);
        }
    }
}
