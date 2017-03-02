using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_13
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, r;

            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            if(x<0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            r = 3 * Math.Sqrt(x);
            Console.WriteLine("{0:N4}", r);
        }
    }
}
