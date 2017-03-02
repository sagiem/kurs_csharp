using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, r;
            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());

            if(a<b)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            r = a * Math.Sqrt(-7 * b);
            Console.WriteLine("{0:N4}", r);
        }
    }
}
