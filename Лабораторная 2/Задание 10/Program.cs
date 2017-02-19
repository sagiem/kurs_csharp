using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double r;
            

            Console.WriteLine("Введите значение x");
            x = double.Parse(Console.ReadLine());
            
            r = Math.Sin(x * Math.PI / 180);
            Console.WriteLine("{0:N4}", r);
        }
    }
}
