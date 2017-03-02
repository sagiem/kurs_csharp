using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.WriteLine("Введите c");
            c = double.Parse(Console.ReadLine());
            if(c==-300)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            f = c * 1.8 + 32;
            Console.WriteLine(f);
        }
    }
}
