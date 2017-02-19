using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, r;

            Console.WriteLine("Введите значение X");
            x = double.Parse(Console.ReadLine());

            if(x<0)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            r = Math.Sqrt(x);
            Console.WriteLine("{0:N4}", r);
        }
    }
}
