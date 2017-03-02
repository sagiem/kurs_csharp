using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, r;

            Console.WriteLine("Введите r");
            r = double.Parse(Console.ReadLine());
            if(r<=0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            v = 4 * Math.PI * r * r * r / 3;
            Console.WriteLine("{0:N4}", v);
        }
    }
}
