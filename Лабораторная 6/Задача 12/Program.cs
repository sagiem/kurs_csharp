using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double s;


            Console.WriteLine("Введите a");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите b");
            b = double.Parse(Console.ReadLine());

            if (b < a)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }

            if(a==b)
            {
                s = a * b;
                Console.WriteLine(s);
                return;
            }



            s = 1;

            while (a <= b)
            {
                s = a*s;
                a++;
            }

            Console.WriteLine(s);
        }
    }
}
