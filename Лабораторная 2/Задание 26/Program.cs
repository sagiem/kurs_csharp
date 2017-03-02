using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_26
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, R;

            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите d");
            d = double.Parse(Console.ReadLine());

            if(a==0||d==0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            R = (a * d + b * c) / (a * d);

            Console.WriteLine("{0:N4}", R);

            
        }
    }
}
