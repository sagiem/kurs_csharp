using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, m;
            Console.WriteLine("Введите a");

            a = double.Parse(Console.ReadLine());
            if(a<0)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }
            m = a % 360;
            Console.WriteLine(m);
        }
    }
}
