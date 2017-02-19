using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, r;

            Console.WriteLine("Введите значение x");
            x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение y");
            y = double.Parse(Console.ReadLine());

            if (y < 0)
            {
                Console.WriteLine("Ошибка");
                return;
            }
            

            if((x+Math.Sqrt(y))<0)
            {
                Console.WriteLine("Ошибка");
                return;
            }

            r = -5 * Math.Sqrt(x + Math.Sqrt(y));
          

            Console.WriteLine("{0:N4}",r);


        }
    }
}
