using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, a;

            Console.WriteLine("Введите значение a");
            a = double.Parse(Console.ReadLine());
            if(a<=0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            v = a * a * a;
            Console.WriteLine(v);
        }
    }
}
