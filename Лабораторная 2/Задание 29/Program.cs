using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, R;

            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());

            if(x<1)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            R = (Math.Sqrt(x + 1) + Math.Sqrt(x - 1)) / (2 * Math.Sqrt(x));

            Console.WriteLine("{0:N4}", R);


        }
    }
}
